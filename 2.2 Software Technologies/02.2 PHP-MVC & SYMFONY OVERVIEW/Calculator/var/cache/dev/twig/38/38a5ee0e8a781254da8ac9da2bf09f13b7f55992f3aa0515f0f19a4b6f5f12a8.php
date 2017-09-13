<?php

/* base.html.twig */
class __TwigTemplate_521b7540e0acaf8476b99c795d9d56b43ae0773b46c1df19e15edfd290a88e36 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_33ec08f489123090b55ab09b8f189c522699d98538d11d8c367d474d46363cc1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_33ec08f489123090b55ab09b8f189c522699d98538d11d8c367d474d46363cc1->enter($__internal_33ec08f489123090b55ab09b8f189c522699d98538d11d8c367d474d46363cc1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_33ec08f489123090b55ab09b8f189c522699d98538d11d8c367d474d46363cc1->leave($__internal_33ec08f489123090b55ab09b8f189c522699d98538d11d8c367d474d46363cc1_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_a5a956e343900910b898b2f09494f4d4b7de86056899b5cf9628ed1a1474236c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a5a956e343900910b898b2f09494f4d4b7de86056899b5cf9628ed1a1474236c->enter($__internal_a5a956e343900910b898b2f09494f4d4b7de86056899b5cf9628ed1a1474236c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_a5a956e343900910b898b2f09494f4d4b7de86056899b5cf9628ed1a1474236c->leave($__internal_a5a956e343900910b898b2f09494f4d4b7de86056899b5cf9628ed1a1474236c_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_c7040acd8cb7c1038e715b9693ce0ed2294062276dc8bd051bdcd7903530f3d8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c7040acd8cb7c1038e715b9693ce0ed2294062276dc8bd051bdcd7903530f3d8->enter($__internal_c7040acd8cb7c1038e715b9693ce0ed2294062276dc8bd051bdcd7903530f3d8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_c7040acd8cb7c1038e715b9693ce0ed2294062276dc8bd051bdcd7903530f3d8->leave($__internal_c7040acd8cb7c1038e715b9693ce0ed2294062276dc8bd051bdcd7903530f3d8_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_da179e582938d1faf4c6c3569824d8ca80a0346d2c284c23aa0e0a04c61b8f2c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_da179e582938d1faf4c6c3569824d8ca80a0346d2c284c23aa0e0a04c61b8f2c->enter($__internal_da179e582938d1faf4c6c3569824d8ca80a0346d2c284c23aa0e0a04c61b8f2c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_da179e582938d1faf4c6c3569824d8ca80a0346d2c284c23aa0e0a04c61b8f2c->leave($__internal_da179e582938d1faf4c6c3569824d8ca80a0346d2c284c23aa0e0a04c61b8f2c_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_02fc7de556f4e382768559c88f70807d69e46cc8cfc92401a19fe9e7541bd63e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_02fc7de556f4e382768559c88f70807d69e46cc8cfc92401a19fe9e7541bd63e->enter($__internal_02fc7de556f4e382768559c88f70807d69e46cc8cfc92401a19fe9e7541bd63e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_02fc7de556f4e382768559c88f70807d69e46cc8cfc92401a19fe9e7541bd63e->leave($__internal_02fc7de556f4e382768559c88f70807d69e46cc8cfc92401a19fe9e7541bd63e_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_9f9f2f2896dbe3c6f8ece3f8f30cb8b40332a39ad7fbd65e53c0b05dea640874 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9f9f2f2896dbe3c6f8ece3f8f30cb8b40332a39ad7fbd65e53c0b05dea640874->enter($__internal_9f9f2f2896dbe3c6f8ece3f8f30cb8b40332a39ad7fbd65e53c0b05dea640874_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_9f9f2f2896dbe3c6f8ece3f8f30cb8b40332a39ad7fbd65e53c0b05dea640874->leave($__internal_9f9f2f2896dbe3c6f8ece3f8f30cb8b40332a39ad7fbd65e53c0b05dea640874_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_007dc4e1a8ee1cd6c7d6d620724af72fde9ea5550e05018d386197c655de50de = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_007dc4e1a8ee1cd6c7d6d620724af72fde9ea5550e05018d386197c655de50de->enter($__internal_007dc4e1a8ee1cd6c7d6d620724af72fde9ea5550e05018d386197c655de50de_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_007dc4e1a8ee1cd6c7d6d620724af72fde9ea5550e05018d386197c655de50de->leave($__internal_007dc4e1a8ee1cd6c7d6d620724af72fde9ea5550e05018d386197c655de50de_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_76ec74090eab78aa8ab3675763fa0e9abddda91984cb96624bb3a2ea551123aa = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_76ec74090eab78aa8ab3675763fa0e9abddda91984cb96624bb3a2ea551123aa->enter($__internal_76ec74090eab78aa8ab3675763fa0e9abddda91984cb96624bb3a2ea551123aa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_76ec74090eab78aa8ab3675763fa0e9abddda91984cb96624bb3a2ea551123aa->leave($__internal_76ec74090eab78aa8ab3675763fa0e9abddda91984cb96624bb3a2ea551123aa_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
