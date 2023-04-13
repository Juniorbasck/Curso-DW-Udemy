<?php 

    session_start();

    //verifica se autenticação foi realizada
    $usuarios_autenticado = false; 
    $usuarios_id = null;
    $usuarios_perfil_id = null;

    $perfis = array(1 => 'Administrativo', 2 => 'Usuário');

    //usuarios do sistemas
    $usuarios_app = array(
        array('id' => 1, 'email' => 'adm@teste.com.br', 'senha' => '1234', 'perfil_id' => 1),
        array('id' => 2, 'email' => 'user@teste.com.br', 'senha' => '1234','perfil_id' => 1),
        array('id' => 3, 'email' => 'jose@teste.com.br', 'senha' => '1234', 'perfil_id' => 2),
        array('id' => 4, 'email' => 'maria@teste.com.br', 'senha' => '1234', 'perfil_id' => 2),
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
            $usuarios_id = $user['id'];
            $usuarios_perfil_id = $user['perfil_id'];
        }
    };

    if($usuarios_autenticado){
        echo 'Usuário autenticado';
        $_SESSION['autenticado'] = 'SIM';
        $_SESSION['id'] = $usuarios_id;
        $_SESSION['perfil_id'] = $usuarios_perfil_id;
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