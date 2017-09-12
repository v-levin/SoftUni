<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        table * {
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
    $backgroundColor = 51;
    for ($row = 0; $row < 5; $row++) {
        echo "<tr>";
        echo "<td style='background-color: rgb($backgroundColor, 0, 0)'></td>";
        echo "<td style='background-color: rgb(0, $backgroundColor, 0)'></td>";
        echo "<td style='background-color: rgb(0, 0, $backgroundColor)'></td>";
        echo "</tr>";
        $backgroundColor += 51;
    }

    ?>
</table>
</body>
</html>