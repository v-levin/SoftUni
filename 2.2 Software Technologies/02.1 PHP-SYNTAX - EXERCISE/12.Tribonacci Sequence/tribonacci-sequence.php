<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php

if (isset($_GET["num"])) {
    $num = intval($_GET["num"]);

    $thirdLastNum = 1;
    $secondLastNum = 1;
    $currentNum = 2;

    echo $thirdLastNum . " " . $secondLastNum . " " . $currentNum . " ";

    for ($i = 0; $i < $num - 3; $i++) {
        $nextNum = $thirdLastNum + $secondLastNum + $currentNum;

        echo $nextNum . " ";

        $thirdLastNum = $secondLastNum;
        $secondLastNum = $currentNum;
        $currentNum = $nextNum;
    }
}

?>
</body>
</html>