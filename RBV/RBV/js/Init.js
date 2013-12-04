debugger;
Sys.Application.add_init(AppInit);

function AppInit(sender) {
    debugger;
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(End);
}

function End(sender, args) { }