
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.Button buttonSuma;
	
	private global::Gtk.Entry entryNumero1;
	
	private global::Gtk.Entry entryNumero2;
	
	private global::Gtk.Label labelResultado;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.buttonSuma = new global::Gtk.Button ();
		this.buttonSuma.CanFocus = true;
		this.buttonSuma.Name = "buttonSuma";
		this.buttonSuma.UseUnderline = true;
		this.buttonSuma.Label = global::Mono.Unix.Catalog.GetString ("+");
		this.table1.Add (this.buttonSuma);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonSuma]));
		w1.LeftAttach = ((uint)(1));
		w1.RightAttach = ((uint)(2));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entryNumero1 = new global::Gtk.Entry ();
		this.entryNumero1.CanFocus = true;
		this.entryNumero1.Name = "entryNumero1";
		this.entryNumero1.IsEditable = true;
		this.entryNumero1.InvisibleChar = '•';
		this.table1.Add (this.entryNumero1);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryNumero1]));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entryNumero2 = new global::Gtk.Entry ();
		this.entryNumero2.CanFocus = true;
		this.entryNumero2.Name = "entryNumero2";
		this.entryNumero2.IsEditable = true;
		this.entryNumero2.InvisibleChar = '•';
		this.table1.Add (this.entryNumero2);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryNumero2]));
		w3.TopAttach = ((uint)(1));
		w3.BottomAttach = ((uint)(2));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.labelResultado = new global::Gtk.Label ();
		this.labelResultado.Name = "labelResultado";
		this.table1.Add (this.labelResultado);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelResultado]));
		w4.TopAttach = ((uint)(2));
		w4.BottomAttach = ((uint)(3));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add (this.table1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 250;
		this.DefaultHeight = 117;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}