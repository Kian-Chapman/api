<?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET, POST");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");
header("Content-Type: application/json; charset=UTF-8");

$servername = "localhost";
$username = "root"; // default username for XAMPP
$password = ""; // default password for XAMPP
$dbname = "api";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$request_method = $_SERVER["REQUEST_METHOD"];

switch($request_method) {
    case 'GET':
        // Retrieve data
        if (isset($_GET['id'])) {
            $id = intval($_GET['id']);
            get_user($id);
        } else {
            get_users();
        }
        break;
    case 'POST':
        // Insert data
        $data = json_decode(file_get_contents("php://input"), true);
        insert_user($data);
        break;
    default:
        // Invalid request method
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}

function get_users() {
    global $conn;
    $query = "SELECT users.id, users.name, users.email, authority_levels.level_name 
              FROM users 
              LEFT JOIN authority_levels ON users.authority_level_id = authority_levels.id";
    $result = $conn->query($query);
    $users = array();
    while($row = $result->fetch_assoc()) {
        $users[] = $row;
    }
    echo json_encode($users);
}

function get_user($id) {
    global $conn;
    $query = "SELECT users.id, users.name, users.email, authority_levels.level_name 
              FROM users 
              LEFT JOIN authority_levels ON users.authority_level_id = authority_levels.id 
              WHERE users.id = $id";
    $result = $conn->query($query);
    $user = $result->fetch_assoc();
    echo json_encode($user);
}

function insert_user($data) {
    global $conn;
    $name = $data['name'];
    $email = $data['email'];
    $authority_level_id = $data['authority_level_id'];
    
    $query = "INSERT INTO users (name, email, authority_level_id) VALUES ('$name', '$email', $authority_level_id)";
    
    if ($conn->query($query) === TRUE) {
        $response = array('status' => 1, 'status_message' => 'User added successfully.');
    } else {
        $response = array('status' => 0, 'status_message' => 'User addition failed.');
    }
    echo json_encode($response);
}

$conn->close();
?>
