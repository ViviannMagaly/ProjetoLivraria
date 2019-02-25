function Alerta(mensagem) {
    $('#mensagem').append('<br/>');
    $('#mensagem').append('<div class="alert alert-danger" role="alert">' + mensagem + '</div>');
}

function AdicionarBemVindo(nomeUsuario) {

    $('#BemVindo').append(' <li class="nav-item">Bem vindo, ' + nomeUsuario + '.</li>');
}