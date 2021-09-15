$(document).ready(function(){
    listartipo();
    tbody2();
});


function listartipo(){
    $.get('https://localhost:5001/api/tipo/listar')
    .done(function(resposta){
        for(i = 0; i < resposta.length; i++){
            let option = $('<option></option>').val(resposta[i].id).html(resposta[i].nome);
            $('#id_tipo').append(option);
        }
       

    })
    .fail(function(erro ,mensagem, exceçao){
        alert('error404');

    });
}


function tbody2(){
    $.get('https://localhost:5001/api/produtotip/listar')
    .done(function(resposta){
        for(i = 0; i < resposta.length; i++){
            let linha = $('<tr></tr>');


            let celulaNome = $('<td></td>').html(resposta[i].nome);
            linha.append(celulaNome);


            let celulaCodigo = $('<td></td>').html(resposta[i].codigo);
            linha.append(celulaCodigo);


            let celulaTipo = $('<td></td>').html(resposta[i].tipo);
            linha.append(celulaTipo);


            
            $('#tbody2').append(linha);
        }
        
        
        
    })
     
}

//validação do formulario!

function disparo() {
    let erro = false;

    let validado = validarCampo(dados.nome, 'Nome');
    if (!validado) {
        erro = true;
    }
    
    validado = validarCampo(dados.codigo, 'codigo');
    if (!validado) {
        erro = true;
    }

    validado = validarCampo(dados.tipo , 'tipo');
    if (!validado) {
        erro = true;
    }

    validado = validarCampo(dados.armazenagem , 'armazenagem');
    if (!validado) {
        erro = true;
    }

    
   if (!erro){
    alert('campos preenchidos! ');
}

function validarCampo(campo, nomeCampo){
    if (campo.value == null || campo.value == '' || campo.value == 0) {
        campo.className = 'vermelho';
		
        alert('Preencha o campo ' + nomeCampo + '!');

        return false;
    } else {
        return true;
    }
}

function removerClasse(campo){
	campo.removeAttribute('class');
}

}
/////////////////////////////////////////////////////////////////

$('.thead2').css('background-color', 'lightgreen');

