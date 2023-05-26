using MandhegParkingSystem.Models;
using MandhegParkingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandhegParkingSystem
{
    public partial class VehicleUC : UserControl
    {
        CrudStateManager stateManager = new CrudStateManager();
        Control[] inputFields;
        Control[] crudButtons;
        Control[] nonCrudButtons;
        int selectedVehicleId;
        public VehicleUC()
        {
            InitializeComponent();
            inputFields = new Control[]
            {
                license_plateTextBox, vehicle_type_ComboBox, ownerTextBox, notesTextBox, 
            };
            crudButtons = new Control[]
            {
                btnInsert, btnDelete, btnUpdate
            };
            nonCrudButtons = new Control[]
            {
                btnSubmit, btnCancel
            };
            vehicle_type_ComboBox.DataSource = Vars.db.VehicleTypes.Select(sel => sel).ToList();
            vehicle_type_ComboBox.ValueMember = "id";
            vehicle_type_ComboBox.DisplayMember = "name";
            vehicle_type_ComboBox.Setup();
            searchComboBox.Setup();
            updateUI();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            List<string> searcedMembers = Vars.db.Members.Select(mem => mem.name).ToList();
            foreach (string member in searcedMembers)
            {
                source.Add(member);
            }
            ownerTextBox.AutoCompleteMode = AutoCompleteMode.Append;
            ownerTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ownerTextBox.AutoCompleteCustomSource = source;
        }

        private void updateUI()
        {
            switch (stateManager.instance)
            {
                case (CrudState.Insert):
                    inputFields.Clear();
                    crudButtons.Disable();
                    nonCrudButtons.Enable();
                    inputFields.Enable();
                    FillDGV();
                    break;
                case (CrudState.Update):
                    crudButtons.Disable();
                    nonCrudButtons.Enable();
                    inputFields.Enable();
                    FillDGV();
                    break;
                case (CrudState.Delete):
                    inputFields.Clear();
                    crudButtons.Disable();
                    nonCrudButtons.Enable();
                    inputFields.Enable();
                    break;
                case (CrudState.Idle):
                    inputFields.Disable();
                    inputFields.Clear();
                    crudButtons.Enable();
                    nonCrudButtons.Disable();
                    FillDGV();
                    break;
            }
        }

        private void FillDGV(string query = "")
        {
            if (query == "")
            {
                vehicleDataGridView.DataSource = Vars.db.Vehicles.Where(v => v.deleted_at == null).Select(v => new
                {
                    id = v.id,
                    ua = v.last_updated_at,
                    da = v.deleted_at,
                    ca = v.created_at,
                    Owner = v.member_id + " - " + v.Member.name.ToString(),
                    License_Plate = v.license_plate.ToString(),
                    Vehicle_Type = Vars.db.VehicleTypes.Where(vt => vt.id == v.vehicle_type_id).FirstOrDefault().name.ToString(),
                        Notes = (v.notes == null) ? " " : v.notes,
                }).ToList();
            } else
            {
                if (searchComboBox.SelectedIndex == 0)
                {
                    vehicleDataGridView.DataSource = Vars.db.Vehicles.Where(v => v.deleted_at == null && v.Member.name.ToLower().Contains(query.ToLower())).Select(v => new
                    {
                        id = v.id,
                        ua = v.last_updated_at,
                        da = v.deleted_at,
                        ca = v.created_at,
                        Owner = v.member_id + " - " + v.Member.name.ToString(),
                        License_Plate = v.license_plate.ToString(),
                        Vehicle_Type = Vars.db.VehicleTypes.Where(vt => vt.id == v.vehicle_type_id).FirstOrDefault().name.ToString(),
                        Notes = (v.notes == null) ? " " : v.notes,
                    }).ToList();
                } else
                {
                    vehicleDataGridView.DataSource = Vars.db.Vehicles.Where(v => v.deleted_at == null && v.license_plate.ToLower().Contains(query.ToLower())).Select(v => new
                    {
                        id = v.id,
                        ua = v.last_updated_at,
                        da = v.deleted_at,
                        ca = v.created_at,
                        Owner = v.member_id + " - " + v.Member.name.ToString(),
                        License_Plate = v.license_plate.ToString(),
                        Vehicle_Type = Vars.db.VehicleTypes.Where(vt => vt.id == v.vehicle_type_id).FirstOrDefault().name.ToString(),
                        Notes = (v.notes == null) ? " " : v.notes,
                    }).ToList();
                }
            }
            vehicleDataGridView.HideColumns(
                new string[]
                {
                    "ua", "da", "ca", "id"
                });
            vehicleDataGridView.Setup();
        }

        private void VehicleUC_Load(object sender, EventArgs e)
        {

        }

        private void vehicleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vehicleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = vehicleDataGridView.CurrentRow.Cells;
            license_plateTextBox.Text = cells["License_Plate"].Value.ToString();
            vehicle_type_ComboBox.Text = cells["Vehicle_Type"].Value.ToString();
            ownerTextBox.Text = cells["Owner"].Value.ToString();
            notesTextBox.Text = cells["Notes"].Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (stateManager.instance)
            {
                case CrudState.Insert:
                    Vars.db.Vehicles.Add(new Vehicle
                    {
                        vehicle_type_id = Convert.ToInt32(vehicle_type_ComboBox.SelectedValue),
                        member_id = Convert.ToInt32(Vars.db.Members.Where(mem => mem.name.ToLower() == ownerTextBox.Text.ToLower()).FirstOrDefault().id),
                        license_plate = license_plateTextBox.Text,
                        notes = notesTextBox.Text,
                        created_at = DateTime.Now,
                    });
                    Vars.db.SaveChanges();
                    break;
                case CrudState.Update:
                    var vehicle = Vars.db.Vehicles.Find(selectedVehicleId);
                    vehicle.vehicle_type_id = Convert.ToInt32(vehicle_type_ComboBox.SelectedValue);
                    vehicle.member_id = Convert.ToInt32(Vars.db.Members.Where(mem => mem.name.ToLower() == ownerTextBox.Text.ToLower()).FirstOrDefault().id);
                    vehicle.license_plate = license_plateTextBox.Text;
                    vehicle.notes = notesTextBox.Text;
                    vehicle.created_at = DateTime.Now;
                    Vars.db.SaveChanges();
                    break;
                case CrudState.Delete:
                    var vehicleToDelete = Vars.db.Vehicles.Find(selectedVehicleId);
                    Vars.db.Vehicles.Remove(vehicleToDelete);
                    Vars.db.SaveChanges();
                    break;
            }
            stateManager.ToIdle();
            updateUI();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            stateManager.ToIdle();
            updateUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedVehicleId = Convert.ToInt32(vehicleDataGridView.CurrentRow.Cells["id"].Value);
            stateManager.ToDelete();
            updateUI();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedVehicleId = Convert.ToInt32(vehicleDataGridView.CurrentRow.Cells["id"].Value);
            stateManager.ToUpdate();
            updateUI();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            stateManager.ToInsert();
            updateUI();
        }

        private void ownerTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            FillDGV(searchTextBox.Text);
        }
    }
}
