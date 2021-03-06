﻿using System.Web;
using System.Web.Optimization;

namespace ITTechs
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // готово к выпуску, используйте средство сборки по адресу https://modernizr.com, чтобы выбрать только необходимые тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/admin").Include(
                      "~/Scripts/AdminMenu.js"));

            bundles.Add(new ScriptBundle("~/bundles/ui").Include(
                      "~/Scripts/carret.js",
                      "~/Scripts/JWPlayer.js",
                      "~/Scripts/RegisterCode.js",
                      "~/Scripts/RegisterUser.js",
                       "~/Scripts/login.js",
                       "~/Scripts/forgot-password.js"));

            bundles.Add(new StyleBundle("~/Content/ittech").Include(
                      "~/Content/navbar.css",
                      "~/Content/thumbnails.css",
                      "~/Content/ProductContent.css",
                      "~/Content/carret.css",
                      "~/Content/RegisterCode.css",
                      "~/Content/RegisterUser.css",
                      "~/Content/login.css",
                      "~/Content/forgot-password.css"));
        }
    }
}
