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

            listadesepesas.push(desespesa)
        }

        return listadesepesas; 
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

function carregaListaDespesas(){

    let desespesa = Array()

    desespesa = bd.recuperarRegistros(); 
    

    console.log(desespesa)
}