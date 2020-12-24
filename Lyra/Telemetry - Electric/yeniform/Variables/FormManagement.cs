using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{

    /*
     * openChildForm fonkisyonu açılacak olan formu ve formun açılacağı paneli parametre olarak alır
     * kullanmak için gerekli yerde fonksiyonun içine bu parametreleri giriniz
     * anasayfaya dönmek için ise activeForm değişkeni kullanılmıştır
     * anasayfaya dönme bölümünde activeForm'un null olup olmadığını kontrol edin
    */

    public class FormManagement
    {

        public static Form activeForm = null;
        public static void openChildForm(Form childForm, Panel panelChildForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
