
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Entry entryNumero1;
	
	private global::Gtk.Entry entryNumero2;
	
	private global::Gtk.VBox vbox6;
	
	private global::Gtk.HBox hbox6;
	
	private global::Gtk.Button buttonSuma;
	
	private global::Gtk.Button resta;
	
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.Button multiplicación;
	
	private global::Gtk.Button división;
	
	private global::Gtk.HBox hbox7;
	
	private global::Gtk.Label labelResultado;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.entryNumero1 = new global::Gtk.Entry ();
		this.entryNumero1.CanFocus = true;
		this.entryNumero1.Name = "entryNumero1";
		this.entryNumero1.IsEditable = true;
		this.entryNumero1.InvisibleChar = '•';
		this.vbox2.Add (this.entryNumero1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.entryNumero1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.entryNumero2 = new global::Gtk.Entry ();
		this.entryNumero2.CanFocus = true;
		this.entryNumero2.Name = "entryNumero2";
		this.entryNumero2.IsEditable = true;
		this.entryNumero2.InvisibleChar = '•';
		this.vbox2.Add (this.entryNumero2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.entryNumero2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.buttonSuma = new global::Gtk.Button ();
		this.buttonSuma.CanFocus = true;
		this.buttonSuma.Name = "buttonSuma";
		this.buttonSuma.UseUnderline = true;
		this.buttonSuma.Label = global::Mono.Unix.Catalog.GetString ("+");
		this.hbox6.Add (this.buttonSuma);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.buttonSuma]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.resta = new global::Gtk.Button ();
		this.resta.CanFocus = true;
		this.resta.Name = "resta";
		this.resta.UseUnderline = true;
		this.resta.Label = global::Mono.Unix.Catalog.GetString ("-");
		this.hbox6.Add (this.resta);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.resta]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox6.Add (this.hbox6);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox6]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.multiplicación = new global::Gtk.Button ();
		this.multiplicación.CanFocus = true;
		this.multiplicación.Name = "multiplicación";
		this.multiplicación.UseUnderline = true;
		this.multiplicación.Label = global::Mono.Unix.Catalog.GetString ("*");
		this.hbox5.Add (this.multiplicación);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.multiplicación]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.división = new global::Gtk.Button ();
		this.división.CanFocus = true;
		this.división.Name = "división";
		this.división.UseUnderline = true;
		this.división.Label = global::Mono.Unix.Catalog.GetString ("/");
		this.hbox5.Add (this.división);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.división]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox6.Add (this.hbox5);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox5]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		this.vbox2.Add (this.vbox6);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox6]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.labelResultado = new global::Gtk.Label ();
		this.labelResultado.Name = "labelResultado";
		this.labelResultado.LabelProp = global::Mono.Unix.Catalog.GetString ("resultado");
		this.hbox7.Add (this.labelResultado);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.labelResultado]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox2.Add (this.hbox7);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox7]));
		w11.Position = 3;
		w11.Expand = false;
		w11.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 160;
		this.DefaultHeight = 202;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
