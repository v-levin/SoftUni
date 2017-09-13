<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_ae9eec45ef5abda27292a0eb4ff0c821e1eb65fceef3f0c8d6ea79ff8833e9b9 extends Twig_Template
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
        $__internal_9032a9d8f12b3c196ae15468f502ad2ee9ac9237957a26ccb734c748653d7ffc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9032a9d8f12b3c196ae15468f502ad2ee9ac9237957a26ccb734c748653d7ffc->enter($__internal_9032a9d8f12b3c196ae15468f502ad2ee9ac9237957a26ccb734c748653d7ffc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_9032a9d8f12b3c196ae15468f502ad2ee9ac9237957a26ccb734c748653d7ffc->leave($__internal_9032a9d8f12b3c196ae15468f502ad2ee9ac9237957a26ccb734c748653d7ffc_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_77003a7e8350331a17d7fd3bc5db331d11c7de4318e7cc3c0507d652f5c171af = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_77003a7e8350331a17d7fd3bc5db331d11c7de4318e7cc3c0507d652f5c171af->enter($__internal_77003a7e8350331a17d7fd3bc5db331d11c7de4318e7cc3c0507d652f5c171af_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_77003a7e8350331a17d7fd3bc5db331d11c7de4318e7cc3c0507d652f5c171af->leave($__internal_77003a7e8350331a17d7fd3bc5db331d11c7de4318e7cc3c0507d652f5c171af_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_cc2abbfd9333c9766337c4ac6158cc2c28c5efe63566eab833e9ba4660a76978 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cc2abbfd9333c9766337c4ac6158cc2c28c5efe63566eab833e9ba4660a76978->enter($__internal_cc2abbfd9333c9766337c4ac6158cc2c28c5efe63566eab833e9ba4660a76978_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_cc2abbfd9333c9766337c4ac6158cc2c28c5efe63566eab833e9ba4660a76978->leave($__internal_cc2abbfd9333c9766337c4ac6158cc2c28c5efe63566eab833e9ba4660a76978_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_9f1fb0a07777b4630402bca569fbea33158403bf15436455a636dfef27247b1a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9f1fb0a07777b4630402bca569fbea33158403bf15436455a636dfef27247b1a->enter($__internal_9f1fb0a07777b4630402bca569fbea33158403bf15436455a636dfef27247b1a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_9f1fb0a07777b4630402bca569fbea33158403bf15436455a636dfef27247b1a->leave($__internal_9f1fb0a07777b4630402bca569fbea33158403bf15436455a636dfef27247b1a_prof);

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
