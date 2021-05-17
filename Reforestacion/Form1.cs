using Reforestacion.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Reforestacion
{
    public partial class Form1 : Form
    {
        Conn con = new Conn();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconsul_Click(object sender, EventArgs e)
        {
            dynamic respuesta = con.Get("http://www.apidonaciones.somee.com/api/donacion");
            //txtmuni.Text = respuesta.id.ToString();
            dataGridView1.DataSource = respuesta;
           
        }

        private void btnactu_Click(object sender, EventArgs e)
        {
            donar arb = new donar
            {
                nombre_mpio = txtmuni.Text,
                nombre_arbol = txtarbol.Text,
                cantidad = Convert.ToInt32(txtcanti.Text)
            };
            string json = JsonConvert.SerializeObject(arb);
            dynamic respuesta = con.Post("http://www.apidonaciones.somee.com/api/donacion", json);
            MessageBox.Show("Se agregarón los datos");
            eliminar();
        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Visible = fila.Cells["clmuni"].Value.ToString().ToUpper().Contains(txtbusca.Text.ToUpper());

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtmuni.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtarbol.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcanti.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            donar donar = new donar
            {
                id = Convert.ToInt32(txtid.Text),
                nombre_mpio = txtmuni.Text,
                nombre_arbol = txtarbol.Text,
                cantidad = Convert.ToInt32(txtcanti.Text)
                };
            string json = JsonConvert.SerializeObject(donar);
            string id = txtid.Text;
            dynamic respuesta = con.Put("http://www.apidonaciones.somee.com/api/donacion/"+txtid.Text+"",id,json);
            MessageBox.Show("Se actualizarón los datos");
            eliminar();
            
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            dynamic respuesta = con.Delete("http://www.apidonaciones.somee.com/api/donacion/" + txtid.Text + "", id);
            MessageBox.Show("Se eliminaron los datos");
            eliminar();
        }
        
        public void eliminar()
        {
            txtid.Text = "";
            txtmuni.Text = "";
            txtarbol.Text = "";
            txtcanti.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int canti = (Convert.ToInt32(txtcanti.Text) + Convert.ToInt32(txtdonar.Text));
            donar donar = new donar
            {
                id = Convert.ToInt32(txtid.Text),
                nombre_mpio = txtmuni.Text,
                nombre_arbol = txtarbol.Text,
                cantidad = canti
            };
            string json = JsonConvert.SerializeObject(donar);
            string id = txtid.Text;
            dynamic respuesta = con.Put("http://www.apidonaciones.somee.com/api/donacion/" + txtid.Text + "", id, json);
            MessageBox.Show("Se donarón los arboles",Convert.ToString(canti));
            eliminar();
            txtdonar.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Visible = fila.Cells["clarbol"].Value.ToString().ToUpper().Contains(textBox1.Text.ToUpper());

            }
        }
    }


    public class donar
    {
        public int id { get; set;  }
        public string nombre_mpio { get; set; }
        public string nombre_arbol { get; set; }
        public int cantidad { get; set; }
    
    }
}
