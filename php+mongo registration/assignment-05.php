
<?php
    
    require 'vendor/autoload.php';
    $client = new MongoDB\Client("mongodb+srv://adminUser:test123@cluster0.s1mzm.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
    $collection = $client->users->userdata;
    

    //$cursor = $collection ->find();
    
    $Title = $_POST['Title'];
    $Fname = $_POST['Fname'];
    $Sname = $_POST['SName'];
    $Mobile = $_POST['Mobile'];
    $Email = $_POST['Email'];
    $AL1 = $_POST['AL1'];
    $AL2 = $_POST['AL2'];
    $Town = $_POST['Town'];
    $County = $_POST['County'];
    $Eircode = $_POST['Eircode'];
    

    // perform a query (get everything) on the selected collection
    $result = $collection->find()->toArray();
    // and display the results
    foreach ($result as $entry) {
        //echo $entry['FName'], ' ', $entry['LName'], ' (', $entry['email'], ')',"\n";
    }

    //CREATE
    $result = $collection->insertOne( ['title'=>$Title, 'firstName'=>$Fname,'lastName'=>$Sname,'mobile'=>$Mobile,'email'=>$Email,'addressOne'=>$AL1,'addressTwo'=>$AL2,'town'=>$Town,'city'=>$County,'eircode'=>$Eircode] );
    echo "\nInserted new entry with Object ID '{$result->getInsertedId()}'\n";
    
    //READ
    echo "\nDisplaying userdata:\n\n";
    $result = $collection->find()->toArray();
    foreach ($result as $entry) {
        echo $entry['title'], '. ', $entry['firstName'], ' ', $entry['lastName'],' ', $entry['mobile'] .PHP_EOL. 
        '[', $entry['email'], ']' .PHP_EOL.
        $entry['addressOne'],' ',$entry['addressTwo'],' ', $entry['town'],' ', $entry['city'] .PHP_EOL.
        '[', $entry['eircode'],']' .PHP_EOL. "\n";
    }
    echo "\n";

    //
    // Delete an item (document) from the collection
    //

    /*//DELETE
    $deleteResult = $collection->deleteOne(['email' => 'jim@jones.net']);
    printf("Deleted %d document(s)\n", $deleteResult->getDeletedCount());
    // and display the updated collection
    echo "\nAjaxAPIDemo:\n\n";
    $result = $collection->find()->toArray();
    foreach ($result as $entry) {
        echo $entry['FName'], ' ', $entry['LName'], ' (', $entry['email'], ')',"\n";
    }
    echo "\n";
    */
    

?>
