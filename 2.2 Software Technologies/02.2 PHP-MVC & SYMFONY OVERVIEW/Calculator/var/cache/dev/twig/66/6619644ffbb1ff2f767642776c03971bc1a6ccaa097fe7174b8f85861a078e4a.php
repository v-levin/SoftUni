<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_21e4d86a65b440cd4bc66bd1c2efccdab86f1a98df128bd72e20909a2c849963 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_d8781bbc558ccbbcd08313cbf230649f4c0f891d2a06cd1cead72f6e01129e35 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d8781bbc558ccbbcd08313cbf230649f4c0f891d2a06cd1cead72f6e01129e35->enter($__internal_d8781bbc558ccbbcd08313cbf230649f4c0f891d2a06cd1cead72f6e01129e35_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_d8781bbc558ccbbcd08313cbf230649f4c0f891d2a06cd1cead72f6e01129e35->leave($__internal_d8781bbc558ccbbcd08313cbf230649f4c0f891d2a06cd1cead72f6e01129e35_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_bcef2eb8830ab6430e35ed17cbfc7772a649108b9ec2042f29147ae5d947b928 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bcef2eb8830ab6430e35ed17cbfc7772a649108b9ec2042f29147ae5d947b928->enter($__internal_bcef2eb8830ab6430e35ed17cbfc7772a649108b9ec2042f29147ae5d947b928_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_bcef2eb8830ab6430e35ed17cbfc7772a649108b9ec2042f29147ae5d947b928->leave($__internal_bcef2eb8830ab6430e35ed17cbfc7772a649108b9ec2042f29147ae5d947b928_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_05a1fd8eceb9dfdb47f1f1e47abcb294a66b09d8c022a9123dd30f52b4e7a248 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_05a1fd8eceb9dfdb47f1f1e47abcb294a66b09d8c022a9123dd30f52b4e7a248->enter($__internal_05a1fd8eceb9dfdb47f1f1e47abcb294a66b09d8c022a9123dd30f52b4e7a248_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_05a1fd8eceb9dfdb47f1f1e47abcb294a66b09d8c022a9123dd30f52b4e7a248->leave($__internal_05a1fd8eceb9dfdb47f1f1e47abcb294a66b09d8c022a9123dd30f52b4e7a248_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_f7cf81648eb822e1c9d89e697d12f809ef5ba607a8d8d51b49399e5faac4cdd4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f7cf81648eb822e1c9d89e697d12f809ef5ba607a8d8d51b49399e5faac4cdd4->enter($__internal_f7cf81648eb822e1c9d89e697d12f809ef5ba607a8d8d51b49399e5faac4cdd4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_f7cf81648eb822e1c9d89e697d12f809ef5ba607a8d8d51b49399e5faac4cdd4->leave($__internal_f7cf81648eb822e1c9d89e697d12f809ef5ba607a8d8d51b49399e5faac4cdd4_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
