﻿using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CustomerPresenter
    {
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerListBildingSource(customerBindingSource);

            LoadAllCustomerList();

            this.view.Show();

        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customer = new CustomerModel();
            customer.Id = Convert.ToInt32(view.CustomerId);
            customer.First_Name = view.CustomerFirst_Name;
            customer.Last_Name = view.CustomerLast_Name;
            customer.Document = view.CustomerDocument;
            customer.Address = view.CustomerAddress;
            DateTime birthday;
            if (DateTime.TryParse(view.CustomerBirthday, out birthday))
            {
                customer.Birthday = birthday;
            }
            else
            {
                MessageBox.Show("La fecha de nacimiento no tiene un formato válido.");
            }
            customer.Phone = view.CustomerPhone;
            customer.Email = view.CustomerEmail;

            try
            {
                new Common.ModelDataValidation().Validate(customer);
                if (view.IsEdit)
                {
                    repository.Edit(customer);
                    view.Message = "Customer Edit Successfuly";
                }
                else
                {
                    repository.Add(customer);
                    view.Message = "Customer added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            view.CustomerId = "0";
            view.CustomerFirst_Name = "";
            view.CustomerLast_Name = "";
            view.CustomerDocument = "";
            view.CustomerAddress = "";
            view.CustomerBirthday = "";
            view.CustomerPhone = "";
            view.CustomerEmail = "";
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel)customerBindingSource.Current;
                repository.Delete(customer.Id);
                view.IsSuccessful = true;
                view.Message = "Customer deleted Successfuly";
                LoadAllCustomerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Customer";
            }
        }

        private void LoadSelectCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomerModel)customerBindingSource.Current;

            view.CustomerId = customer.Id.ToString();
            view.CustomerFirst_Name = customer.First_Name;
            view.CustomerLast_Name = customer.Last_Name;
            view.CustomerDocument = customer.Document;
            view.CustomerAddress = customer.Address;
            view.CustomerBirthday = customer.Birthday?.ToString("dd/MM/yyyy") ?? string.Empty;
            view.CustomerPhone = customer.Phone;
            view.CustomerEmail = customer.Email;

            view.IsEdit = true;
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customerList = repository.GetAll();
            }
            customerBindingSource.DataSource = customerList;
        }
    }
}

