function Alerta(mensagem) {
    $('#mensagem').append('<br/>');
    $('#mensagem').append('<div class="alert alert-danger" role="alert">' + mensagem + "</div>");
}