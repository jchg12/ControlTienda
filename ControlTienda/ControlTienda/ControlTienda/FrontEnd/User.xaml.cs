using ControlTienda.Data;
using ControlTienda.Data.Entities;
using ControlTienda.Encrypt;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ControlTienda.FrontEnd
{
    /// <summary>
    /// Lógica de interacción para User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User()
        {
            InitializeComponent();
        }

        private void CbRol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            string name, address, phone, nickname, password;
            User user = new User(); Rol rol = new Rol();
            Encrypting encrypting = new Encrypting();
            DataContext context = new DataContext();
            Data.Entities.UserRepository repository = new UserRepository(context);

            name = TbName.Text;
            address = TbAddress.Text;
            phone = TbPhone.Text;
            nickname = TbNickName.Text;
            password = TbPassword.Password;

            int id = (from u in context.Users
                      where u.Nickname == nickname
                      select u.Id).FirstOrDefault();

            if (!repository.Exist(id))
            {
                user.Name = name;
                user.Address = address;
                user.Phone = phone;
                user.Nickname = nickname;
                user.Password = encrypting.GetSHA256(password);
                user.RolId = Convert.ToInt16(CbRol.SelectedValue);
                repository.Create(user);
                MessageBox.Show("User Created. " + user.Name);
                RefreshDataGrid();
            }
            else
                MessageBox.Show("The User Nick exist, change it please.");
        }


    }
}
}
