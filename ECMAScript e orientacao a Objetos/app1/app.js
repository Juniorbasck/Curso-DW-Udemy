class Despesa{
    constructor(ano, mes, dia, tipo, descricao, valor){
        this.ano = ano
        this.mes = mes
        this.dia = dia
        this.tipo = tipo
        this.descricao = descricao
        this.valor = valor
    }

    validarDados(){
        for(let i in this){
            if(this[i] == undefined || this[i] == '' || this[i] == null){
                return false;
            }
        }
        return true
    }
}

class Bd{
    
    constructor(){
        let id = localStorage.getItem('id')

        if(id === null){
            localStorage.setItem('id', 0)
        }
    }

    getProximoId(){
        let ProximoId = localStorage.getItem('id')

        return (parseInt(ProximoId) + 1);
    }

    gravar(d){
        
        let id = this.getProximoId()

        localStorage.setItem(id, JSON.stringify(d))

        localStorage.setItem('id', id)
    }

    recuperarRegistros(){
        
        //array de desespesas
        let listadesepesas = Array()

        let id = localStorage.getItem('id')

        for(let i = 1;  i <= id; i++){

            let desespesa = JSON.parse(localStorage.getItem(i))
            
            //verificar se tem indices removidos/nesse caso pular esse indices
            if(desespesa === null){
                continue
            }

            desespesa.id = i
            listadesepesas.push(desespesa)
        }

        return listadesepesas; 
    }

    pesquisar(despesa){

        let despesasFiltradas = Array()

        
        despesasFiltradas = this.recuperarRegistros()

        console.log(despesa);
        console.log(despesasFiltradas);
            

        //ano 
        if(despesa.ano !== ''){
               
             despesasFiltradas = despesasFiltradas.filter(d => d.ano == despesa.ano)
        }

        //mes
        if(despesa.mes !== ''){
        
            despesasFiltradas = despesasFiltradas.filter(d => d.mes == despesa.mes)
        }

        //dia
        if(despesa.dia !== ''){
            
            despesasFiltradas = despesasFiltradas.filter(d => d.dia == despesa.dia)
        }

        //tipo 
        if(despesa.tipo !== ''){
            
            despesasFiltradas = despesasFiltradas.filter(d => d.tipo == despesa.tipo)
        }


        //descricao
        if(despesa.descricao !== ''){
             
            despesasFiltradas = despesasFiltradas.filter(d => d.descricao == despesa.descricao)
        }


        //valor
        if(despesa.valor !== ''){
            
            despesasFiltradas = despesasFiltradas.filter(d => d.valor == despesa.valor)
        }


        return despesasFiltradas; 
    }

    remover(id){
        console.log('Evento desparado')
        localStorage.removeItem(id)
    }
}

let bd = new Bd()


function cadatrarDespesas(){
    
    let ano = document.getElementById('ano')
    let mes = document.getElementById('mes')
    let dia = document.getElementById('dia')
    let tipo = document.getElementById('tipo')
    let descricao = document.getElementById('descricao')
    let valor = document.getElementById('valor')
    


    let despesa = new Despesa(
         ano.value,
         mes.value, 
         dia.value, 
         tipo.value, 
         descricao.value, 
         valor.value
    ) 

    if(despesa.validarDados()){

        bd.gravar(despesa);
        

        document.getElementById('modal_titulo').innerHTML = 'Regristro inserido com sucesso'
        document.getElementById('corModal').className = 'modal-header text-success'
        document.getElementById('modalConteudo').innerHTML = 'Despesa foi cadastrada com sucesso'
        document.getElementById('modal_btn').className = 'btn btn-success'
        document.getElementById('modal_btn').innerHTML = 'Voltar'


        $('#registrarDesespesas').modal('show');

         document.getElementById('ano').value = ''
         document.getElementById('mes').value = ''
         document.getElementById('dia').value = ''
         document.getElementById('tipo').value = ''
         document.getElementById('descricao').value = ''
         document.getElementById('valor').value = ''
        
    }else{
        //dialogi de erro
        document.getElementById('modal_titulo').innerHTML = 'Não foi possivel inserir'
        document.getElementById('corModal').className = 'modal-header text-danger'
        document.getElementById('modalConteudo').innerHTML = 'Para cadastrar nova despesa tem que preencher todos os campos'
        document.getElementById('modal_btn').className = 'btn btn-danger'
        document.getElementById('modal_btn').innerHTML = 'Voltar e corrigir'


        $('#registrarDesespesas').modal('show');
    }
}

function carregaListaDespesas(desespesa = Array(), filtro = false){
    
    if(desespesa.length == 0 && filtro == false){
        
        desespesa = bd.recuperarRegistros(); 
    }
    
    //selecionando a tabela
    //percorrer o array despesas listando cada despesa de forma dinamica
    let listaDespesa = document.getElementById('listaDesespesas')
    listaDespesa.innerHTML = '';

    desespesa.forEach(function(d){
       
        //console.log(d)

        let linha = listaDespesa.insertRow()

        linha.insertCell(0).innerHTML = `${d.dia}/${d.mes}/${d.ano}`
        

        //ajustaar o tipo 

        switch(d.tipo){
            case '1': d.tipo = 'Alimentação'
                break
            case '2': d.tipo = 'Educação'
                break
            case '3': d.tipo = 'Lazer'
                break
            case '4': d.tipo = 'Saúde'
                break
            case '5': d.tipo = 'Transporte'
                break
        }

        linha.insertCell(1).innerHTML = d.tipo
        linha.insertCell(2).innerHTML = d.descricao
        linha.insertCell(3).innerHTML = d.valor

        //criar botão de exclusão
        let btn = document.createElement('button')
        btn.className = 'btn btn-danger'
        btn.innerHTML = '<i class="fas fa-times"></i>'
        btn.id = d.id
        btn.onclick = function(){
            
            bd.remover(this.id)
            console.log(this.id)
            window.location.reload();
        }
        linha.insertCell(4).append(btn)

        //console.log(d)
    })

}

function pesquisarDespesa(){
    

    let ano = document.getElementById('ano').value
    let mes = document.getElementById('mes').value
    let dia  = document.getElementById('dia').value
    let tipo  = document.getElementById('tipo').value
    let descricao = document.getElementById('descricao').value
    let valor = document.getElementById('valor').value

    let despesa = new Despesa(ano, mes, dia, tipo, descricao, valor); 


    let desespesas = bd.pesquisar(despesa)
    
    carregaListaDespesas(desespesas, true);
}