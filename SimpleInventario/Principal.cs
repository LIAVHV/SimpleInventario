using MaterialSkin;
using MaterialSkin.Controls;
using SimpleInventario.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace SimpleInventario
{
    public partial class Principal : MaterialForm
    {

        public Principal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple400, TextShade.WHITE);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.GetUnidadesCombo();
            this.GetProductosCombo();
            this.GetUnidadesGrid();
            this.GetProductosGrid();
            this.cargaReporte();
            this.lblTitCatUnidades.Text = "1. Catálogo de Unidades de Medida";
            this.lblTitCatProd.Text = "2. Catálogo de Producto o Servicio";
            this.lblTitEntradas.Text = "3. Entradas de Productos o Servicio";
            this.lblTitSalidas.Text = "4. Salida de Productos o Servicio";
        }

        private void btnUnidad_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())

            {
                //int ide = Convert.ToInt32(this.dgUnidades.CurrentRow.Cells[0].Value);
                var addUnidad = new Unidades { Unidad = this.txtUnidad.Text.ToUpper().Trim() };
                db.Unidades.Add(addUnidad);

                try
                {
                    db.SaveChanges();
                    MaterialMessageBox.Show("El registro se agrego ", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    this.txtUnidad.Text = string.Empty;
                    this.txtUnidad.Focus();
                    this.GetUnidadesGrid();
                    this.GetUnidadesCombo();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var exe in ex.EntityValidationErrors)
                    {
                        foreach (var error in exe.ValidationErrors)
                        {
                            MaterialMessageBox.Show($"Error: {error.ErrorMessage}", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                    }
                    this.txtUnidad.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.InnerException.Message.Contains("duplicate"))
                    {
                        MaterialMessageBox.Show($"Ya existe la unidad, no se puede guardar", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                }
            }
        }

        private void GetUnidadesGrid()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var unidades = db.Unidades.ToList();
                this.dgUnidades.Refresh();
                this.dgUnidades.DataSource = unidades;
            }
        }

        private void GetProductosGrid()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var productos = db.Productos.Include("FkUnidadesId").Select(x => new { x.ProductosId, x.Nombre, x.Unidades.Unidad, x.Precio, x.Existencia, x.FkUnidadesId }).ToList();
                this.dgProductos.DataSource = productos;
                // OCULTA LA COLUMNA DE FkUnidadesId ,esta columna se usa para la eliminacion de producto
                this.dgProductos.Columns[5].Visible = false;
                this.dgProductos.Refresh();
            }
        }

        private void GetUnidadesCombo()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var catUnidades = db.Unidades.OrderBy(x => x.Unidad).ToList();
                this.ddlCatProdUnidad.DataSource = catUnidades;
                this.ddlCatProdUnidad.ValueMember = "UnidadesId";
                this.ddlCatProdUnidad.DisplayMember = "Unidad";
            }
        }

        private void GetProductosCombo()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var catProductos = db.Productos.OrderBy(x => x.Nombre).ToList();

                AutoCompleteStringCollection stringCollectionProductos = new AutoCompleteStringCollection();

                foreach (var item in catProductos)
                {
                    stringCollectionProductos.Add(item.Nombre);
                }

                this.ddlEntradaProducto.AutoCompleteCustomSource = stringCollectionProductos;
                this.ddlEntradaProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.ddlEntradaProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;

                this.ddlEntradaProducto.DataSource = catProductos;
                this.ddlEntradaProducto.ValueMember = "ProductosId";
                this.ddlEntradaProducto.DisplayMember = "Nombre";

                this.ddlSalidaProducto.AutoCompleteCustomSource = stringCollectionProductos;
                this.ddlSalidaProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.ddlSalidaProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;

                this.ddlSalidaProducto.DataSource = catProductos;
                this.ddlSalidaProducto.ValueMember = "ProductosId";
                this.ddlSalidaProducto.DisplayMember = "Nombre";
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var selUnidad = this.ddlCatProdUnidad.SelectedItem as Unidades;
                var producto = new Productos
                {
                    Nombre = this.txtCatProdNombre.Text.ToUpper().Trim(),
                    FkUnidadesId = selUnidad.UnidadesId,
                    Precio = 0,
                };

                db.Productos.Add(producto);
                try
                {
                    db.SaveChanges();
                    MaterialMessageBox.Show("El PRODUCTO se agrego ", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    this.txtCatProdNombre.Text = string.Empty;
                    this.txtCatProdNombre.Focus();
                    this.GetProductosGrid();
                    this.GetProductosCombo();
                    this.cargaReporte();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var exe in ex.EntityValidationErrors)
                    {
                        foreach (var error in exe.ValidationErrors)
                        {
                            MaterialMessageBox.Show($"Error: {error.ErrorMessage}", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                    }
                    this.txtUnidad.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.InnerException.Message.Contains("duplicate key"))
                    {
                        MaterialMessageBox.Show("El producto ya existe, no se puede guardar", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                    else
                    {
                        MaterialMessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                }
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                int ide = Convert.ToInt32(this.ddlEntradaProducto.SelectedValue);

                if (string.IsNullOrEmpty(this.txtEntradaPrecio.Text.Trim()) || string.IsNullOrEmpty(this.txtEntradaCantidad.Text.Trim()) || ide == 0)
                {
                    MaterialMessageBox.Show("El producto,precio o cantidad no puede ser 0 o vacio", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                }

                else
                {
                    decimal precio = Convert.ToDecimal(this.txtEntradaPrecio.Text.Trim());
                    decimal cantidad = Convert.ToDecimal(this.txtEntradaCantidad.Text.Trim());

                    if (ide == 0)
                    {
                        MaterialMessageBox.Show("El producto que ingreso no existe", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                    else
                    {

                        if (precio > 0 && cantidad > 0)
                        {
                            var entrada = new Entradas
                            {
                                FKProductosId = ide,
                                Precio = precio,
                                Cantidad = cantidad,
                                TotalImporte = precio * cantidad,
                                Fecha = DateTime.Now
                            };
                            db.Entradas.Add(entrada);

                            var productos = db.Productos.Find(entrada.FKProductosId);
                            if (productos == null)
                            {
                                MaterialMessageBox.Show("El producto que ingreso no existe", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                            }
                            productos.Existencia += entrada.Cantidad;
                            productos.Precio = entrada.Precio;
                            db.Entry(productos).State = EntityState.Modified;

                            try
                            {
                                db.SaveChanges();
                                this.lbExistenciaEntrada.Text = $"Existencia: {string.Format("{0:F2}", productos.Existencia)}";
                                this.GetProductosGrid();
                                this.cargaReporte();
                                MaterialMessageBox.Show("La entrada se agrego", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                            }
                            catch (Exception ex)
                            {
                                MaterialMessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                            }
                        }
                        else
                        {
                            MaterialMessageBox.Show("No se pueden registrar valores en 0", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                    }
                }
            }

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var id = Convert.ToInt32(this.ddlSalidaProducto.SelectedValue);
                decimal existencia = db.Productos.Where(x => x.ProductosId == id).Select(x => x.Existencia).FirstOrDefault();
                decimal precio = db.Productos.Where(x => x.ProductosId == id).Select(x => x.Precio).FirstOrDefault();
                decimal cantidad = Convert.ToDecimal(this.txtSalidaCantidad.Text.Trim());

                if (existencia >= cantidad)
                {
                    if (cantidad > 0)
                    {
                        var salida = new Salidas
                        {
                            FKProductosId = id,
                            Cantidad = cantidad,
                            Precio = precio,
                            TotalImporte = (precio * cantidad) * -1,
                            Fecha = DateTime.Now
                        };
                        db.Salidas.Add(salida);

                        var productos = db.Productos.Find(id);
                        productos.Existencia -= salida.Cantidad;
                        db.Entry(productos).State = EntityState.Modified;
                        try
                        {
                            db.SaveChanges();
                            this.lbPrecioSalida.Text = $"Precio: {string.Format("{0:C2}", productos.Precio)}";
                            this.lbExistenciaSalida.Text = $"Existencia: {string.Format("{0:F2}", productos.Existencia)}";
                            this.GetProductosGrid();
                            this.cargaReporte();
                            MaterialMessageBox.Show("La salida se agrego", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                        catch (Exception ex)
                        {
                            MaterialMessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                    }
                    else
                    {
                        MaterialMessageBox.Show("No se pueden registrar valores negativos o sin Stock de Inventario", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                }
                else
                {
                    MaterialMessageBox.Show("No existe Stock suficiente", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                }
            }

        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCatProdNombre.Text = this.dgProductos.CurrentRow.Cells[1].Value.ToString();
            this.ddlCatProdUnidad.SelectedValue = this.dgProductos.CurrentRow.Cells[5].Value;
            this.ddlCatProdUnidad.Refresh();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                int ide = Convert.ToInt32(this.dgProductos.CurrentRow.Cells[0].Value);

                if (ide > 0)
                {
                    var producto = db.Productos.Find(ide);
                    db.Productos.Remove(producto);
                    try
                    {
                        db.SaveChanges();
                        this.txtCatProdNombre.Text = string.Empty;
                        this.ddlSalidaProducto.SelectedValue = 1;
                        this.GetProductosGrid();
                        this.GetProductosCombo();
                        this.cargaReporte();
                        MaterialMessageBox.Show("El PRODUCTO se ELIMINO ", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                    catch (Exception ex)
                    {

                        if (ex.InnerException.InnerException.Message.Contains("FK_dbo.Entradas_dbo.Productos_FKProductosId"))
                        {
                            MaterialMessageBox.Show("Existen ENTRADAS o SALIDAS del PRODUCTO, no se puede ELIMINAR", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        };
                    }
                }
            }
        }

        private void cargaReporte()
        {
            this.existenciasTableAdapter.Fill(this.dsReportes.Existencias);
            this.reportViewer1.RefreshReport();

            this.kardexTableAdapter.Fill(this.dsReportes.Kardex);
            this.reportViewer2.RefreshReport();
        }

        private void BtnUnidadEliminar_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                int ide = Convert.ToInt32(this.dgUnidades.CurrentRow.Cells[0].Value);

                if (ide > 0)
                {
                    var id = db.Unidades.Find(ide);
                    db.Unidades.Remove(id);
                    try
                    {
                        db.SaveChanges();
                        MaterialMessageBox.Show("La UNIDAD DE MEDIDA se ELIMINO ", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        this.txtUnidad.Text = string.Empty;
                        this.GetUnidadesGrid();
                        this.GetUnidadesCombo();
                    }
                    catch (Exception ex)
                    {
                        if (ex.InnerException.InnerException.Message.Contains("FK_dbo.Productos_dbo.Unidades_FkUnidadesId"))
                        {
                            MaterialMessageBox.Show("Existen ENTRADAS o SALIDAS del PRODUCTO, no se puede ELIMINAR", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                        else
                        {
                            MaterialMessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                    }
                }
            }
        }

        private void dgUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtUnidad.Text = this.dgUnidades.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnModificarUnidad_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())

            {
                int ide = Convert.ToInt32(this.dgUnidades.CurrentRow.Cells[0].Value);
                var addUnidad = db.Unidades.Find(ide);
                addUnidad.Unidad = this.txtUnidad.Text.Trim();
                db.Entry(addUnidad).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                    MaterialMessageBox.Show("El registro se modifico ", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    this.txtUnidad.Text = string.Empty;
                    this.txtUnidad.Focus();
                    this.GetUnidadesGrid();
                    this.GetUnidadesCombo();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var exe in ex.EntityValidationErrors)
                    {
                        foreach (var error in exe.ValidationErrors)
                        {
                            MaterialMessageBox.Show($"Error: {error.ErrorMessage}", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                    }
                    this.txtUnidad.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.InnerException.Message.Contains("duplicate"))
                    {
                        MaterialMessageBox.Show($"Ya existe la unidad, no se puede guardar", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                }
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                int ide = Convert.ToInt32(this.dgProductos.CurrentRow.Cells[0].Value);
                var selUnidad = this.ddlCatProdUnidad.SelectedItem as Unidades;
                var producto = db.Productos.Find(ide);
                producto.Nombre = this.txtCatProdNombre.Text.ToUpper().Trim();
                producto.FkUnidadesId = selUnidad.UnidadesId;

                db.Entry(producto).State = EntityState.Modified;
                try
                {
                    db.SaveChanges();
                    MaterialMessageBox.Show("El PRODUCTO se agrego ", "Informacion", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    this.txtCatProdNombre.Text = string.Empty;
                    this.txtCatProdNombre.Focus();
                    this.GetProductosGrid();
                    this.GetProductosCombo();
                    this.cargaReporte();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var exe in ex.EntityValidationErrors)
                    {
                        foreach (var error in exe.ValidationErrors)
                        {
                            MaterialMessageBox.Show($"Error: {error.ErrorMessage}", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                        }
                    }
                    this.txtUnidad.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.InnerException.Message.Contains("duplicate key"))
                    {
                        MaterialMessageBox.Show("El producto ya existe, no se puede guardar", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                    else
                    {
                        MaterialMessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                }
            }
        }
    }
}
