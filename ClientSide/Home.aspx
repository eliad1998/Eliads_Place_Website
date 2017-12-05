<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Welcome</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" Runat="Server">
 
            <!-- START Fullscreen block -->
            <div class="tm-fullscreen uk-position-relative">
                <div class="akslider-module ">
                    <div class="uk-slidenav-position" data-uk-slideshow="{height: 'auto', animation: 'scale', duration: '500', autoplay: false, autoplayInterval: '7000', videoautoplay: true, videomute: true, kenburns: false}">
                        <ul class="uk-slideshow">
                            <li class="uk-cover uk-height-viewport uk-active">
                                <!-- START Slide 15jlooooooooooooo  -->
                                <div class="uk-cover-background uk-position-cover" style="background-image: url(images/demo/slider/slide_1.jpg);"></div>
                                <img src="images/demo/slider/slide_1.jpg" width="800" height="400" alt="Go to Gym">
                                <div class="uk-caption uk-caption-panel uk-animation-fade uk-flex uk-flex-center uk-flex-middle">
                                    <div class="tm-slide-style-1">
                                        <h3 class="slide-head tm-heading-font">
                                            it’s right time to
                                        </h3>
                                        <div class="slide-text-primary tm-heading-font">
                                            <a href="#">Go to Gym</a>
                                        </div>
                                        <h4 class="slide-subhead uk-text-right tm-heading-font">
                                            starts from $19.99<sup>/month</sup>
                                        </h4>
                                    </div>
                                </div>
                                <!-- END Slide 1 -->
                            </li>
                            <li class="uk-cover uk-height-viewport">
                                <!-- START Slide 2 -->
                                <div class="uk-cover-background uk-position-cover" style="background-image: url(images/demo/slider/slide_2.jpg);"></div>
                                <img src="images/demo/slider/slide_2.jpg" width="800" height="400" alt="Kickboxing">
                                <div class="uk-caption uk-caption-panel uk-animation-fade uk-flex uk-flex-center uk-flex-middle">
                                    <div class="tm-slide-style-2">
                                        <div class="slide-text-primary">
                                            <a href="#">Kickboxing</a>
                                        </div>
                                        <div class="tm-slide-panel uk-text-center">
                                            <h4 class="ak-slide-subhead uk-text-center">
                                                Every day from 4:00pm till 08:00pm
                                            </h4>
                                            <a href="location.html" class="uk-button uk-button-primary">View Location</a>
                                        </div>
                                    </div>
                                </div>
                                <!-- END Slide 2 -->
                            </li>
                            <li class="uk-cover uk-height-viewport">
                                <!-- START Slide 3 -->
                                <div class="uk-cover-background uk-position-cover" style="background-image: url(images/demo/slider/slide_3.jpg);"></div>
                                <img src="images/demo/slider/slide_3.jpg" width="800" height="400" alt="Muscle Mass">
                                <div class="uk-caption uk-caption-panel uk-animation-fade uk-flex uk-flex-center uk-flex-middle">
                                    <div class="tm-slide-style-3">
                                        <div class="slide-text-primary">
                                            <a href="#">Muscle Mass</a>
                                        </div>
                                        <div class="tm-slide-panel">
                                            <p class="ak-slide-subhead">
                                                Cras mattis consectetur purus sit amet fermentum. Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Morbi leo risus, porta ac consectetur ac, vestibulum at eros. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum.
                                            </p>
                                            <a href="location.html" class="uk-button uk-button-primary">View Location</a>
                                        </div>
                                    </div>
                                </div>
                                <!-- END Slide 3 -->
                            </li>
                            <li class="uk-cover uk-height-viewport">
                                <!-- START Slide 4 -->
                                <div class="uk-cover-background uk-position-cover" style="background-image: url(images/demo/slider/slide_5.jpg);"></div>
                                <img src="images/demo/slider/slide_5.jpg" width="800" height="400" alt="Go to Gym">
                                <div class="uk-caption uk-caption-panel uk-animation-fade uk-flex uk-flex-center uk-flex-middle">
                                    <div class="tm-slide-style-1">
                                        <div class="slide-text-primary tm-heading-font uk-text-left" style="padding:0;">
                                            <a href="#">New <br>Record</a>
                                        </div>
                                        <h4 class="slide-subhead uk-text-left tm-heading-font">
                                            Every day from 4:00pm till 08:00pm
                                        </h4>
                                        <div class="tm-radial uk-float-left" data-circle-value="0.90">
                                            <div>Duration <span>90 minutes</span></div>
                                        </div>
                                        <div class="tm-radial uk-float-left" data-circle-value="0.35">
                                            <div>Calories <span>600-800</span></div>
                                        </div>
                                        <div class="tm-radial uk-float-left" data-circle-value="0.5">
                                            <div>Level <span>Medium</span></div>
                                        </div>
                                    </div>
                                </div>
                                <!-- END Slide 4 -->
                            </li>
                            <li class="uk-cover uk-height-viewport">
                                <!-- START Slide 5 (Video) -->
                                <iframe src="http://www.youtube.com/embed/PnICxgGHXno?autoplay=1&amp;loop=1&amp;controls=0&amp;showinfo=0&amp;playlist=FoRmhWxmj70&amp;wmode=transparent&amp;vq=hd1080&amp;enablejsapi=1&amp;api=1" width="480" height="270" allowfullscreen="" class="uk-position-absolute" data-uk-cover="{}">
                                </iframe>
                                <!-- END Slide 5 (Video) -->
                            </li>
                        </ul>
                        
                        <!-- START Slider next/prev buttons -->
                        <a href="#" class="uk-slidenav uk-slidenav-contrast uk-slidenav-previous" data-uk-slideshow-item="previous"></a>
                        <a href="#" class="uk-slidenav uk-slidenav-contrast uk-slidenav-next" data-uk-slideshow-item="next"></a>
                        <!-- END Slider next/prev buttons -->
                        
                        <!-- START Slider navigator -->
                        <ul class="uk-dotnav uk-dotnav-contrast uk-position-bottom uk-text-center">
                            <li data-uk-slideshow-item="0" class="uk-active"><a href="#" style="background-image: url('images/demo/slider/slide_1_btn.jpg')">0</a></li>
                            <li data-uk-slideshow-item="1"><a href="#" style="background-image: url('images/demo/slider/slide_2_btn.jpg')">1</a></li>
                            <li data-uk-slideshow-item="2"><a href="#" style="background-image: url('images/demo/slider/slide_3_btn.jpg')">2</a></li>
                            <li data-uk-slideshow-item="3"><a href="#" style="background-image: url('images/demo/slider/slide_5_btn.jpg')">3</a></li>
                            <li data-uk-slideshow-item="4"><a href="#" style="background-image: url('images/demo/slider/slide_6_btn.jpg')">4</a></li>
                        </ul>
                        <!-- END Slider navigator -->

                    </div>
                </div>
            </div>
            <!-- END Fullscreen block -->
            
            <!-- START Features block -->
            <div class="tm-block  tm-block-top-a tm-section-light tm-section-padding-large">
                <div class="uk-container uk-container-center">
                    <section class="tm-top-a uk-grid" data-uk-grid-match="{target:'> div > .uk-panel'}" data-uk-grid-margin="">
                        <div class="uk-width-1-1">
                            <div class="uk-panel">
                                <div class="category-module-features ">
                                    <div class="uk-grid" data-uk-grid-margin="" data-uk-grid-match="{target:'.uk-panel'}">
                                        <div class="uk-width-medium-1-2 uk-width-large-1-4 uk-text-center">
                                            <!-- START Feature 1 -->
                                            <div class="uk-overlay tm-overlay uk-width-1-1">
                                                <div class="uk-panel uk-panel-box">
                                                    <img src="images/demo/visuals/ico-workouts.png" alt="Workouts">                        
                                                    <h2 class="uk-panel-title uk-margin-top">Workouts</h2>
                                                    <p class="tm-panel-subtitle">Morbi leo risus, porta ac consectetur, vestibulum at eros. Vestibulum id ligula porta felis euismod semper. Etiam porta sem malesuada...</p>
                                                </div>
                                                <div class="uk-overlay-area">
                                                    <div class="uk-overlay-area-content">
                                                        <p>Morbi leo risus, porta ac consectetur, vestibulum at eros. Vestibulum id ligula porta felis euismod semper. Etiam porta sem malesuada magna mollis euismod. Vestibulum id ligula porta felis euismod semper. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                                    </div>
                                                </div>
                                            </div>
                                            <a class="uk-button uk-button-large" href="workouts.html" title="View Workouts">
                                                <i class="uk-icon-akplus">+</i>
                                                <span>View Workouts</span>
                                            </a>
                                            <!-- END Feature 1 -->
                                        </div>
                                        <div class="uk-width-medium-1-2 uk-width-large-1-4 uk-text-center">
                                            <!-- START Feature 2 -->
                                            <div class="uk-overlay tm-overlay uk-width-1-1">
                                                <div class="uk-panel uk-panel-box">
                                                    <img src="images/demo/visuals/ico-classes.png" alt="Classes">                        
                                                    <h2 class="uk-panel-title uk-margin-top">Classes</h2>
                                                    <p class="tm-panel-subtitle">Morbi leo risus, porta ac consectetur, vestibulum at eros. Vestibulum id ligula porta felis euismod semper. Etiam porta sem malesuada...</p>
                                                </div>
                                                <div class="uk-overlay-area">
                                                    <div class="uk-overlay-area-content">
                                                        <p>Morbi leo risus, porta ac consectetur, vestibulum at eros. Vestibulum id ligula porta felis euismod semper. Etiam porta sem malesuada magna mollis euismod. Vestibulum id ligula porta felis euismod semper. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                                    </div>
                                                </div>
                                            </div>
                                            <a class="uk-button uk-button-large" href="classes.html" title="View Classes">
                                                <i class="uk-icon-akplus">+</i>
                                                <span>View Classes</span>
                                            </a>
                                            <!-- END Feature 2 -->
                                        </div>
                                        <div class="uk-width-medium-1-2 uk-width-large-1-4 uk-text-center">
                                            <!-- START Feature 3 -->
                                            <div class="uk-overlay tm-overlay uk-width-1-1">
                                                <div class="uk-panel uk-panel-box">
                                                    <img src="images/demo/visuals/ico-schedule.png" alt="Schedule">                        
                                                    <h2 class="uk-panel-title uk-margin-top">Schedule</h2>
                                                    <p class="tm-panel-subtitle">Morbi leo risus, porta ac consectetur, vestibulum at eros. Vestibulum id ligula porta felis euismod semper. Etiam porta sem malesuada...</p>
                                                </div>
                                                <div class="uk-overlay-area">
                                                    <div class="uk-overlay-area-content">
                                                        <p>Morbi leo risus, porta ac consectetur, vestibulum at eros. Vestibulum id ligula porta felis euismod semper. Etiam porta sem malesuada magna mollis euismod. Vestibulum id ligula porta felis euismod semper. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                                    </div>
                                                </div>
                                            </div>
                                            <a class="uk-button uk-button-large" href="schedule.html" title="View Schedule">
                                                <i class="uk-icon-akplus">+</i>
                                                <span>View Schedule</span>
                                            </a>
                                            <!-- END Feature 3 -->
                                        </div>
                                        <div class="uk-width-medium-1-2 uk-width-large-1-4 uk-text-center">
                                            <!-- START Feature 4 -->
                                            <div class="uk-overlay tm-overlay uk-width-1-1">
                                                <div class="uk-panel uk-panel-box">
                                                    <img src="images/demo/visuals/ico-trainers.png" alt="Trainers">                        
                                                    <h2 class="uk-panel-title uk-margin-top">Trainers</h2>
                                                    <p class="tm-panel-subtitle">Eliad Arzuan,Dor Habosha and more</p>
                                                </div>
                                                <div class="uk-overlay-area">
                                                    <div class="uk-overlay-area-content">
                                                        <p>The best SS,FBW,AB,ABC and more programs</p>
                                                    </div>
                                                </div>
                                            </div>
                                            <a class="uk-button uk-button-large" href="Trainers.aspx" title="View Trainers">
                                                <i class="uk-icon-akplus">+</i>
                                                <span>View Trainers</span>
                                            </a>
                                            <!-- END Feature 4 -->
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
            <!-- END Features block -->
            
            <!-- START About block -->
            <div class="tm-block  tm-block-top-b tm-section-dark tm-section-image tm-section-padding-large">
                <div class="uk-container uk-container-center">
                    <section class="tm-top-b uk-grid" data-uk-grid-match="{target:'> div > .uk-panel'}" data-uk-grid-margin="">
                        <div class="uk-width-1-1">
                            <div class="uk-panel">
                                <div class="uk-grid" style="margin-bottom: 110px;">
                                    <div class="uk-width-large-1-2 uk-width-medium-2-3 uk-width-small-1-1">
                                        <h4 class="tm-logo-text">
                                            <span class="color-1">Maxx</span><span class="color-2">Fitness</span>
                                        </h4>
                                        <p class="uk-margin-remove">We are Spotys. Premium HTML Template for small and big gyms. Pellentesque ornare sem lacinia quam venenatis vestibulum. Maecenas sed diam eget risus varius blandit sit amet non magna. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Maecenas faucibus mollis interdum. Vestibulum id ligula porta felis euismod semper.</p>
                                        <ol class="tm-list">
                                            <li>Responsive Design based on UIkit system</li>
                                            <li>FULL-WIDTH SLIDESHOW</li>
                                            <li>RELIABLE CUSTOMER SUPPORT</li>
                                            <li>FULLY FILTERABLE galleries</li>
                                        </ol>
                                        <hr style="margin: 35px 0;">
                                        <a class="uk-button uk-button-large" href="#" title="Buy Now">
                                        Buy Now
                                        </a>
                                        <i class="uk-text-large" style="margin: 0 25px;">or</i>
                                        <a class="uk-text-large" href="#">View more demos</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
            <!-- END About block -->
            
            <!-- START Statistic and Promo block -->
            <div class="tm-block  tm-block-top-c tm-section-light">
                <div class="uk-container uk-container-center">
                    <section class="tm-top-c uk-grid" data-uk-grid-match="{target:'> div > .uk-panel'}" data-uk-grid-margin="">
                        <div class="uk-width-1-1 uk-width-medium-1-2">
                            <div class="uk-panel">
                                <!-- START Statistic block -->
                                <div class="uk-panel uk-text-center ak-statistics-box">
                                    <ul class="uk-subnav uk-subnav-line tm-statistics">
                                        <li class="uk-scrollspy-init-inview">
                                            <div class="digit" data-from="0" data-to="231" data-speed="1400">231</div>
                                            <h6 class="text">Locations</h6>
                                        </li>
                                        <li class="uk-scrollspy-init-inview">
                                            <div class="digit" data-from="0" data-to="736" data-speed="1700">736</div>
                                            <h6 class="text">Trainers</h6>
                                        </li>
                                        <li class="uk-scrollspy-init-inview">
                                            <div class="digit" data-from="0" data-to="32" data-speed="2000">32</div>
                                            <h6 class="text">Shops</h6>
                                        </li>
                                    </ul>
                                </div>
                                <!-- END Statistic block -->
                            </div>
                        </div>
                        <div class="uk-hidden-small uk-width-medium-1-2">
                            <!-- START Promo block -->
                            <div class="uk-panel uk-hidden-small">
                                <a class="tm-promo-video" href="https://vimeo.com/31012462" data-uk-lightbox="{group:'group2'}">
                                    <img src="images/demo/visuals/promo-video.jpg" width="610" height="380" alt="Promo Video"> 
                                </a>
                            </div>
                            <!-- END Promo block -->
                        </div>
                    </section>
                </div>
            </div>
            <!-- END Statistic and Promo block -->
            
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


</asp:Content>

