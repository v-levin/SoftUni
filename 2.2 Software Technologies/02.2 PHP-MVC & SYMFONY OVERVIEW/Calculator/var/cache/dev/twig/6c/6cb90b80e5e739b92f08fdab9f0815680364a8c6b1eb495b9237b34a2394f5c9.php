<?php

/* base.html.twig */
class __TwigTemplate_e255b5ac31e5e34879b2b253fb285e156ad7523b4d993a3f54bcaa07d17b037c extends Twig_Template
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
        $__internal_9a32f5ccb4b297641637a7d70c8ed7942aa2c3477dd95c03a791f20b558f71fb = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9a32f5ccb4b297641637a7d70c8ed7942aa2c3477dd95c03a791f20b558f71fb->enter($__internal_9a32f5ccb4b297641637a7d70c8ed7942aa2c3477dd95c03a791f20b558f71fb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

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
        
        $__internal_9a32f5ccb4b297641637a7d70c8ed7942aa2c3477dd95c03a791f20b558f71fb->leave($__internal_9a32f5ccb4b297641637a7d70c8ed7942aa2c3477dd95c03a791f20b558f71fb_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_8382e65fa3a66f65a9810007da1056ac3dd38d5fa6bee8b76cd330d3b378d11f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8382e65fa3a66f65a9810007da1056ac3dd38d5fa6bee8b76cd330d3b378d11f->enter($__internal_8382e65fa3a66f65a9810007da1056ac3dd38d5fa6bee8b76cd330d3b378d11f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_8382e65fa3a66f65a9810007da1056ac3dd38d5fa6bee8b76cd330d3b378d11f->leave($__internal_8382e65fa3a66f65a9810007da1056ac3dd38d5fa6bee8b76cd330d3b378d11f_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_bccac941c01d6fa8953736cc07d4164bb6c309085f35897ca8583eae51a8807e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bccac941c01d6fa8953736cc07d4164bb6c309085f35897ca8583eae51a8807e->enter($__internal_bccac941c01d6fa8953736cc07d4164bb6c309085f35897ca8583eae51a8807e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_bccac941c01d6fa8953736cc07d4164bb6c309085f35897ca8583eae51a8807e->leave($__internal_bccac941c01d6fa8953736cc07d4164bb6c309085f35897ca8583eae51a8807e_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_a0defbea32fe8a9f1726fff1f39e1a4de575a3c131cf011b8e7278cbcbdc8ce7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a0defbea32fe8a9f1726fff1f39e1a4de575a3c131cf011b8e7278cbcbdc8ce7->enter($__internal_a0defbea32fe8a9f1726fff1f39e1a4de575a3c131cf011b8e7278cbcbdc8ce7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_a0defbea32fe8a9f1726fff1f39e1a4de575a3c131cf011b8e7278cbcbdc8ce7->leave($__internal_a0defbea32fe8a9f1726fff1f39e1a4de575a3c131cf011b8e7278cbcbdc8ce7_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_668012a90a2bc6622216967e62b587fd1f8030b93a5033f093359d67d1ffbc11 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_668012a90a2bc6622216967e62b587fd1f8030b93a5033f093359d67d1ffbc11->enter($__internal_668012a90a2bc6622216967e62b587fd1f8030b93a5033f093359d67d1ffbc11_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

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
        
        $__internal_668012a90a2bc6622216967e62b587fd1f8030b93a5033f093359d67d1ffbc11->leave($__internal_668012a90a2bc6622216967e62b587fd1f8030b93a5033f093359d67d1ffbc11_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_d8029f5492ca3e60e96267eeb493673c05eb383147e58396a60bd570ad748127 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d8029f5492ca3e60e96267eeb493673c05eb383147e58396a60bd570ad748127->enter($__internal_d8029f5492ca3e60e96267eeb493673c05eb383147e58396a60bd570ad748127_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

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
        
        $__internal_d8029f5492ca3e60e96267eeb493673c05eb383147e58396a60bd570ad748127->leave($__internal_d8029f5492ca3e60e96267eeb493673c05eb383147e58396a60bd570ad748127_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_2a927dc016b6fba97db25cce10fad2cf9079d6e8423d4bcdc24e1271cde84f8b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2a927dc016b6fba97db25cce10fad2cf9079d6e8423d4bcdc24e1271cde84f8b->enter($__internal_2a927dc016b6fba97db25cce10fad2cf9079d6e8423d4bcdc24e1271cde84f8b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_2a927dc016b6fba97db25cce10fad2cf9079d6e8423d4bcdc24e1271cde84f8b->leave($__internal_2a927dc016b6fba97db25cce10fad2cf9079d6e8423d4bcdc24e1271cde84f8b_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_f9583a3a7720c24e60f76c9390b5a3a1dfd13178dd0d0ea2d3fbaf518f1eaf42 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f9583a3a7720c24e60f76c9390b5a3a1dfd13178dd0d0ea2d3fbaf518f1eaf42->enter($__internal_f9583a3a7720c24e60f76c9390b5a3a1dfd13178dd0d0ea2d3fbaf518f1eaf42_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

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
        
        $__internal_f9583a3a7720c24e60f76c9390b5a3a1dfd13178dd0d0ea2d3fbaf518f1eaf42->leave($__internal_f9583a3a7720c24e60f76c9390b5a3a1dfd13178dd0d0ea2d3fbaf518f1eaf42_prof);

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
