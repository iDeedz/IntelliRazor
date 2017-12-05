﻿<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>@PageData("Title") - IntelliRazor</title>

    <!-- Bootstrap Core CSS -->
    <link href="~/Assets/css/bootstrap.min.css" rel="stylesheet">

    <!-- Bootstrap Datepicker -->
    <link href="~/Assets/css/datepicker.css" rel="stylesheet">

    <!-- MetisMenu CSS -->
    <link href="~/vendor/metisMenu/metisMenu.min.css" rel="stylesheet">

    <!-- Social Buttons CSS -->
    <link href="~/vendor/bootstrap-social/bootstrap-social.css" rel="stylesheet">

    <!-- DataTables CSS -->
    <link href="~/vendor/datatables-plugins/dataTables.bootstrap.css" rel="stylesheet">

    <!-- DataTables Responsive CSS -->
    <link href="~/vendor/datatables-responsive/dataTables.responsive.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="~/dist/css/sb-admin-2.css" rel="stylesheet">

    <!-- Morris Charts CSS -->
    <link href="~/vendor/morrisjs/morris.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="~/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

    <!-- Custom Styles -->
    <link href="~/Content/custom.css" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>

<body>

    <div id="wrapper">

        @RenderPage("~/Views/Nav_inc.vbhtml")

        <div id="page-wrapper">
            <!-- adding a button to open the modal -->
            <div class="text-center" style="margin-top:100px;">
                <a href="#" id="btn-open" class="btn btn-info btn-lg">Click Me</a>
            </div>


            <div id="MyModal" class="modal fade">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title">Modal title</h4>
                        </div>
                        <div class="modal-body">
                            <p>One fine body&hellip;</p>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                            <button type="button" class="btn btn-primary">Save changes</button>
                        </div>
                    </div><!-- /.modal-content -->
                </div><!-- /.modal-dialog -->
            </div><!-- /.modal -->

        </div>
        <!-- /#page-wrapper -->
    </div>
    <!-- /#wrapper -->
    

    <script>
        !function () { "use strict"; var e = function (e, t) { var o = this; this.el = document.querySelector(e), this.options = t; try { for (var d = document.querySelectorAll("#" + this.el.id + ' [data-dismiss="modal"]'), n = 0; n < d.length; n++) d[n].addEventListener("click", function (e) { e && e.preventDefault(), o.hide() }) } catch (i) { console.log(i) } }; e.prototype.show = function () { var e = this; if (e.options.backdrop) { var t = document.getElementById("bs.backdrop"); null === t && (t = document.createElement("div"), t.id = "bs.backdrop", t.className = "modal-backdrop fade in", document.body.appendChild(t)) } this.el.classList.add("in"), this.el.style.display = "block", document.body.style.paddingRight = "13px", document.body.classList.add("modal-open") }, e.prototype.hide = function () { var e = this; if (this.el.classList.remove("in"), this.el.style.display = "none", document.body.style = "", document.body.classList.remove("modal-open"), e.options.backdrop) { var t = document.getElementById("bs.backdrop"); null !== t && document.body.removeChild(t) } }, document.addEventListener("DOMContentLoaded", function () { var t = new e("#MyModal", { backdrop: !0 }); document.getElementById("btn-open").addEventListener("click", function (e) { e && e.preventDefault(), t.show() }) }) }();
    </script>
</body>

</html>