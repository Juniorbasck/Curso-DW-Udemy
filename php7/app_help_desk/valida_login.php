<?php 

    session_start();

    //verifica se autenticação foi realizada
    $usuarios_autenticado = false; 


    //usuarios do sistemas
    $usuarios_app = array(
        array('email' => 'adm@teste.com.br', 'senha' => '123456'),
        array('email' => 'user@teste.com.br', 'senha' => 'abcd'),
    );  

    
    // echo '<pre>';
    // print_r($usuarios_app);
    // echo '</re>';

    foreach($usuarios_app as $user){

        // echo 'Usuario app: ' . $user['email'] . ' / ' . $user['senha']; 
        // echo '<br>';
        // echo 'Usuario form: ' . $_POST['email'] . ' / ' . $_POST['senha'];
        
        if($user['email'] == $_POST['email'] && $user['senha'] == $_POST['senha']){
            $usuarios_autenticado = true;
        }
    };

    if($usuarios_autenticado){
        echo 'Usuário autenticado';
        $_SESSION['autenticado'] = 'SIM';
        $_SESSION['x'] = 'um valor';
        $_SESSION['y'] = 'outro valor';   
        header('Location: home.php');
    }else{
        $_SESSION['autenticado'] = 'NÃO';
        header('Location: index.php?login=erro');   
    }
    

    /*
    print_r($_GET);

    echo '<br>';
    echo $_GET['email'];
    echo '<br>';
    echo $_GET['senha'];
    */

    // print_r($_POST);
    
    // echo 'br />';

    

?>