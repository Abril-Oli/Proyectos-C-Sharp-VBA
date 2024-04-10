using CarritoServices.Models;
using CarritoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoClient
{
    public partial class Form1 : Form
    {
        private long ultID = 0;

        private readonly List<Article> listArticles;

        private readonly Carrito carrito;

        public Form1()
        {
            InitializeComponent();
            //instanciamos la lista de articulos//
            this.listArticles = new List<Article>();
            this.carrito = new Carrito();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //obtenemos valores de los textbox//
            string description = textBoxDescription.Text;
            string sPrice = textBoxPrice.Text;

            //parseando el precio//
            decimal Price = decimal.Parse(sPrice);

            this.ultID++;

            //creamos nuevo obj tipo articulo//
            Article nuevoArticle = new Article(ultID, description, Price);

            //Guardamos el articulo creado anteriormente en la lista//
            this.listArticles.Add(nuevoArticle);

            //visualizacion de dataGridView//

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listArticles;


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //obtengo valor de txtb de id//
            string sID = textBoxId.Text;

            //parseo de valor id obtenido//
            long Id = long.Parse(sID);


            //for each para recorrer lista//

            foreach(Article article in listArticles)
            {
                //por art de turno, dar id// 
                if(article.Id == Id)
                {
           //si el id del art de turno es igual al id del Textboxidagregar al carrito//
          //la fx de agregar sale de agregar(), hecha con sv, CarritoServices//         
                 carrito.agregar(article);
                 break;
                
                }
            }
            //obtengo total de carrito y se parseo a string//
            string sTotalCarrito= carrito.getTotal().ToString();

            //con el total lo muestro en el labelTotalCarrito//
            this.labelTotal.Text = sTotalCarrito;

        }

    }
}
