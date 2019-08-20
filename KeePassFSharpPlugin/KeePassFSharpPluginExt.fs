namespace KeePassFSharpPlugin

open KeePass.Plugins
open System
open System.Windows.Forms

type KeePassFSharpPluginExt() = 
    inherit Plugin()
    let mutable m_host = null
    override this.Initialize(host: IPluginHost): bool = 
        if (host = null) then
            false
        else
            m_host <- host
            true
        
    override this.Terminate() = 
        ()
    
    override this.GetMenuItem(t: PluginMenuType): ToolStripMenuItem = 
        match t with
        | PluginMenuType.Main -> 
            let tsmi = new ToolStripMenuItem()
            tsmi.Text <- "Test F# Plugin Options"
            tsmi.Click.AddHandler(new EventHandler(this.OnOptionsClicked))
            tsmi
        | _ -> null

    member private this.OnOptionsClicked(sender: obj)(e: EventArgs) = 
        MessageBox.Show("You clicked the menu item for this plugin!") |> ignore
        ()
