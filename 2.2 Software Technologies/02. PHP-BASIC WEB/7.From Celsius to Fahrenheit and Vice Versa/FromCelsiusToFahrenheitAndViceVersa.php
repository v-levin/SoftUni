<?php

$msgAfterCelsius = null;
$msgAfterFahrenheit = null;

if (isset($_GET["cel"])) {
    $celsius = htmlspecialchars($_GET["cel"]);
    $msgAfterCelsius = "$celsius &deg;C = " . celsiusToFahrenheit($celsius) . "&deg;F";
} else if (isset($_GET["fah"])) {
    $fahrenheit = htmlspecialchars($_GET["fah"]);
    $msgAfterFahrenheit = "$fahrenheit &deg;F = " . fahrenheitToCelsius($fahrenheit) . "&deg;C";
}

function celsiusToFahrenheit(float $celsius) : float {
    return $celsius * 1.8 + 32;
}

function fahrenheitToCelsius(float $fahrenheit) : float {
    return ($fahrenheit - 32) / 1.8;
}
?>
<form>
    Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?= $msgAfterCelsius ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
    <?= $msgAfterFahrenheit ?>
</form>

