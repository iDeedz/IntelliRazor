﻿@Code
    Layout = "~/Views/_V4.vbhtml"
    PageData("Title") = "Home"
End Code

<!--wrapper start-->
<div class="wrapper" id="wrapper">

    <!--header-->
    <header>
        <div class="jumbotron jumbotron-fluid" id="banner">
            <div class="parallax text-center" style="background-image: url(img/cover.jpg);">
                <div class="parallax-pattern-overlay">
                    <div class="container text-center" id="size-banner">
                        <a href="#"><img id="site-title" src="img/logo.png" alt="logo" /></a>
                        <h2 class="display-2">Boostrap 4 Beta is here!</h2>
                        <h3 class="learn">Wanna know how to use it?</h3>
                    </div>
                </div>
            </div>
        </div>



    </header>

    <!--about us-->
    <section class="aboutus" id="aboutus">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="heading text-center">
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h2>About Boostrap 4 Beta</h2>

                        <img class="dividerline" src="img/sep.png" alt="">
                        <h3><mark>Bootstrap</mark> is the world’s most popular framework for building responsive, mobile-first sites and applications. Inside you’ll find high quality HTML, CSS, and JavaScript to make starting any project easier than ever. On <mark>August 19</mark>, Bootstrap 4 alpha was released with the removal of support for IE8. Of course, there are still going to be a couple of alphas before they move to the beta phase, but this gives us a glimpse on what to expect on the next versions.</h3>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3">
                    <div class="card">
                        <img class="card-img-top" src="img/card1.jpg" alt="Card image cap">
                        <div class="card-block">
                            <h4 class="card-title">This is Card #1</h4>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="http://v4-alpha.getbootstrap.com/components/card/" class="btn btn-primary">Learn More</a>
                        </div>
                    </div>
                </div>

                <div class="col-md-3">
                    <div class="card card-inverse card-primary text-center">
                        <img class="card-img-top" src="img/card2.jpg" alt="Card image cap">
                        <div class="card-block">
                            <h4 class="card-title">This is Card #2</h4>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="http://v4-alpha.getbootstrap.com/components/card/" class="btn btn-primary">Learn More</a>
                        </div>
                    </div>
                </div>


                <div class="col-md-3">
                    <div class="card card-inverse card-success text-center">
                        <img class="card-img-top" src="img/card3.jpg" alt="Card image cap">
                        <div class="card-block">
                            <h4 class="card-title">This is Card #3</h4>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="http://v4-alpha.getbootstrap.com/components/card/" class="btn btn-primary">Learn More</a>
                        </div>
                    </div>
                </div>

                <div class="col-md-3">
                    <div class="card card-inverse card-info text-center">
                        <img class="card-img-top" src="img/card4.jpg" alt="Card image cap">
                        <div class="card-block">
                            <h4 class="card-title">This is Card #4</h4>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href="http://v4-alpha.getbootstrap.com/components/card/" class="btn btn-primary">Learn More</a>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>


    <section class="features" id="features">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="heading text-center">
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h2>Enhanced Features</h2>
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h3><a href="#" data-toggle="tooltip" title="This is a tooltip">Bootstrap 4 alpha</a> has a new prefix <a href="#" data-toggle="tooltip" title="Make all backgrounds black!">–inverse</a> class that gives a background to the table itself. Another cool thing about this is the improve tooltips and popovers which help a lot of developers when it comes to ease of use. Thanks to <a href="#" data-toggle="tooltip" title="Tether is a JavaScript library for efficiently making an absolutely positioned element stay next to another element on the page. For example, you might want a tooltip or dialog to open, and remain, next to the relevant item on the page.">Tether</a> , a third party library it has improved. </h3>
                    </div>
                </div>
            </div>


            <div class="row">
                <div class="col-md-6">
                    <table class="table table-inverse">
                        <thead>
                            <tr><th colspan="3" class="text-center">Bootstrap 3</th> </tr>
                            <tr>
                                <th>Size</th>
                                <th>Device</th>
                                <th>Class</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Extra Small</td>
                                <td>Less than 768px</td>
                                <td>col-xs</td>
                            </tr>

                            <tr>
                                <td>Small</td>
                                <td>768px and up</td>
                                <td>col-sm</td>
                            </tr>

                            <tr>
                                <td>Medium</td>
                                <td>992px and up</td>
                                <td>col-md</td>
                            </tr>

                            <tr>
                                <td>Large</td>
                                <td>1200px and up</td>
                                <td>col-lg</td>
                            </tr>


                        </tbody>
                    </table>
                </div>

                <div class="col-md-6">
                    <table class="table table-inverse">
                        <thead>
                            <tr><th colspan="3" class="text-center">Bootstrap 4</th> </tr>
                            <tr>
                                <th>Size</th>
                                <th>Device</th>
                                <th>Class</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Extra Small</td>
                                <td>Less than 34em</td>
                                <td>col-xs</td>
                            </tr>

                            <tr>
                                <td>Small</td>
                                <td>34em and up</td>
                                <td>col-sm</td>
                            </tr>

                            <tr>
                                <td>Medium</td>
                                <td>48em and up</td>
                                <td>col-md</td>
                            </tr>

                            <tr>
                                <td>Large</td>
                                <td>62em and up</td>
                                <td>col-lg</td>
                            </tr>

                            <tr>
                                <td>Extra Large</td>
                                <td>75em and up</td>
                                <td>col-xl</td>
                            </tr>

                        </tbody>
                    </table>
                </div>


            </div>
        </div>
    </section>


    <!--Contact Us-->
    <section class="contact" id="contact">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="heading">
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h2>Contact Us</h2>
                        <img class="dividerline" src="img/sep.png" alt="">
                        <h3>
                            Feel free to reach out for any questions!
                        </h3>
                    </div>
                </div>
            </div>
        </div>
        <div class="container mx-width">
            <div class="row">
                <div class="done">
                    <div class="alert alert-success">
                        <button type="button" class="close" data-dismiss="alert">×</button>
                        Your message has been sent. Thank you!
                    </div>
                </div>

                <div class="col-md-12">
                    <form>
                        <fieldset class="form-group">
                            <input type="text" class="form-control" id="Name" placeholder="Name">
                        </fieldset>

                        <fieldset class="form-group">
                            <input type="email" class="form-control" id="Email" placeholder="Email">
                        </fieldset>

                        <fieldset class="form-group">
                            <textarea class="form-control" rows="3" placeholder="Message"></textarea>
                        </fieldset>

                        <button type="submit" class="contact submit">Submit</button>
                    </form>
                </div>


            </div>
        </div>
    </section>

    <!--footer-->
    <section class="footer" id="footer">

        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <ul>
                        <li><a href="#"><i class="fa fa-facebook"></i></a></li>
                        <li><a href="#"><i class="fa fa-twitter"></i></a></li>
                        <li><a href="#"><i class="fa fa-linkedin"></i></a></li>
                        <li><a href="#"><i class="fa fa-pinterest"></i></a></li>

                    </ul>
                    <p>
                        &copy; 2015 - Designmodo.com<br>
                    </p>
                </div>
            </div>
        </div>
    </section>

</div><!--wrapper end-->