function Alerta(mensagem) {
    //alert(mensagem).class('alert alert-danger');
    //$('<div>').class('alert alert-danger').role('alert').title(mensagem).appendTo('body');
    $('#formPrincipal').append('<h1>' + mensagem + '</h1>');
}