$(document).ready(function(){
    listarcategoria();
    tbody2();
});


function listarcategoria(){
    $.get('https://localhost:5001/api/produtotip/listar')
    .done(function(resposta){
        for(i = 0; i < resposta.length; i++){
            let option = $('<option></option>').val(resposta[i].id).html(resposta[i].nome);
            $('#id_categoria').append(option);
        }
       

    })
    .fail(function(erro ,mensagem, exceçao){
        alert('error404');

    });
}


function tbody2(){
    $.get('https://localhost:5001/api/colaborador/listar')
    .done(function(resposta){
        for(i = 0; i < resposta.length; i++){
            let linha = $('<tr></tr>');


            let celulaNome = $('<td></td>').html(resposta[i].nome);
            linha.append(celulaNome);


            let celulaQuantidade = $('<td></td>').html(resposta[i].quantidade);
            linha.append(celulaQuantidade);


            let celulaCategoria = $('<td></td>').html(resposta[i].categoria);
            linha.append(celulaCategoria);


           

            $('#tbody2').append(linha)

            
        }
        
        
        
    })
     
}



        



//validação do formulario!
function disparo(){
   
    let erro = false;

    let validado = validar (dados.nome, 'nome');
    if(!validado){

        erro = true;
    }


    validado = validar(dados.quantidade, 'quantidade');
    if(!validado){
        erro = true ;
    }


    validado = validar(dados.data , 'data');
    if(!validado){
        erro = true ;
    }


    validado = validar(dados.categoria , 'categoria');
    if(!validado){
        erro = true ;
    }


    validado = validar(dados.glutem, 'glutem');
    if(!validado){
        erro = true ;
    }

    
if (!erro){
    alert('campos preenchidos! ');
}

    validado = validarCheckbox(dados.embalagem, 'embalagem');
    if (!validado) {
        erro = true;
    }
    
    return erro;
}




function validar(campo , nomeCampo){
    if ( campo .value == null || campo.value == ''  || campo.value == 0){
        campo.className = 'vermelho';
        alert('preencha o campo ' + nomeCampo +'!');
    
        return false;
    }else{

        campo.className = '';
        return true;
    }
}


function validarCheckbox(checkboxes, nomeCampo){
    for (i = 0; i < checkboxes.length; i++ ){
        if (checkboxes[i].checked){
            return true;
        }
    }
    alert('precha o campo ' + nomeCampo + '!');
    return false;


}  

function removerclasse(campo){
    campo.classname = '';
}
