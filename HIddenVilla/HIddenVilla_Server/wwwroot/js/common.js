//global function, Toastr added via CDNs
window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Operation Successful", {timeOut: 1000});
    }
    if (type === "error") {
        toastr.error(message, "Operation Failed", { timeOut: 1000 });
    }
}


window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire(message, "SUCESS MESSAGE", "success");
    }
    if (type === "error") {
        Swal.fire(message, "ERROR MESSAGE", "error");
    }
}