
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class DeviceComboboxWidget
	{
		private global::Gtk.Alignment alignment2;
		
		private global::Gtk.ComboBox comboboxDevices;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.DeviceComboboxWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BlinkStickClient.DeviceComboboxWidget";
			// Container child BlinkStickClient.DeviceComboboxWidget.Gtk.Container+ContainerChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.comboboxDevices = new global::Gtk.ComboBox ();
			this.comboboxDevices.Name = "comboboxDevices";
			this.alignment2.Add (this.comboboxDevices);
			this.Add (this.alignment2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.comboboxDevices.Changed += new global::System.EventHandler (this.OnComboboxDevicesChanged);
		}
	}
}