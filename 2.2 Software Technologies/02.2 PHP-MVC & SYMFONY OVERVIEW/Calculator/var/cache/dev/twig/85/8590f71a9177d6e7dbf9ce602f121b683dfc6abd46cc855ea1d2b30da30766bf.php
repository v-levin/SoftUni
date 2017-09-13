<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_dc9747328bcd6ac3c832cc29fd81464c90fb7a7ea3f49cb10b78a592d3157300 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_1119baeb85fb0e2fc68284e627e2914258e864cec830c488e2dc8bc3458c398c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1119baeb85fb0e2fc68284e627e2914258e864cec830c488e2dc8bc3458c398c->enter($__internal_1119baeb85fb0e2fc68284e627e2914258e864cec830c488e2dc8bc3458c398c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_1119baeb85fb0e2fc68284e627e2914258e864cec830c488e2dc8bc3458c398c->leave($__internal_1119baeb85fb0e2fc68284e627e2914258e864cec830c488e2dc8bc3458c398c_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_4574dc5a92c7af7d6bbd62036343b1da0e8bccb5c4c51d20ce1479cff953561e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4574dc5a92c7af7d6bbd62036343b1da0e8bccb5c4c51d20ce1479cff953561e->enter($__internal_4574dc5a92c7af7d6bbd62036343b1da0e8bccb5c4c51d20ce1479cff953561e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_4574dc5a92c7af7d6bbd62036343b1da0e8bccb5c4c51d20ce1479cff953561e->leave($__internal_4574dc5a92c7af7d6bbd62036343b1da0e8bccb5c4c51d20ce1479cff953561e_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_7f523de76af350d04b104fd7ad8b355b812c545ba76aa0f76117d19029066212 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7f523de76af350d04b104fd7ad8b355b812c545ba76aa0f76117d19029066212->enter($__internal_7f523de76af350d04b104fd7ad8b355b812c545ba76aa0f76117d19029066212_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_7f523de76af350d04b104fd7ad8b355b812c545ba76aa0f76117d19029066212->leave($__internal_7f523de76af350d04b104fd7ad8b355b812c545ba76aa0f76117d19029066212_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_0d946246332e34e5c93253966561b2f8b37537e675e70cbc34dd21fc90cbc3a1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0d946246332e34e5c93253966561b2f8b37537e675e70cbc34dd21fc90cbc3a1->enter($__internal_0d946246332e34e5c93253966561b2f8b37537e675e70cbc34dd21fc90cbc3a1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_0d946246332e34e5c93253966561b2f8b37537e675e70cbc34dd21fc90cbc3a1->leave($__internal_0d946246332e34e5c93253966561b2f8b37537e675e70cbc34dd21fc90cbc3a1_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
