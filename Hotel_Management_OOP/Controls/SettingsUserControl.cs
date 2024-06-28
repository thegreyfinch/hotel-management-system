using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_OOP
{
    public partial class SettingsUserControl : UserControl
    {
        private UserDataContext? dbContext;
        public SettingsUserControl()
        {
            InitializeComponent();
        }
        /*
                protected override void OnLoad(EventArgs e)
                {
                    base.OnLoad(e);

                    //loading of database objects
                    this.dbContext = new UserDataContext();

                    //this.dbContext.Database.EnsureDeleted();
                    this.dbContext.Database.EnsureCreated();

                    this.dbContext.Users.Load();

                    this.usersBindingSource.DataSource = this.dbContext.Users.Local.ToBindingList();

                }

                protected override void OnClosing(CancelEventArgs e)
                {
                    base.OnClosing(e);

                    this.dbContext?.Dispose();
                    this.dbContext = null;
                }
        */
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (this.dbContext != null)
            {
                var user = (User)this.dataGridView1.CurrentRow.DataBoundItem;

                if (user != null)
                {
                    //this.dbContext.Entry(user).Collection(e => e.Username).Load();
                }
            }
        }
    }
}
