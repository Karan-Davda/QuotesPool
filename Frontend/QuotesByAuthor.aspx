<%@ Page Title="" Language="C#" MasterPageFile="~/Content/QuotesPoolMaster.master" AutoEventWireup="true" CodeFile="QuotesByAuthor.aspx.cs" Inherits="Frontend_QuotesByAuthor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <div class="slider-container rev_slider_wrapper" style="margin-top: 0px; margin-bottom: 0px; position: absolute; max-height: 430px; overflow: visible; height: 430px; width: 200px; left: 0px;">
        <div id="revolutionSlider" class="slider rev_slider" data-version="5.4.8" style="height: 422px">
            <ul>
                <li class="slide-overlay slide-overlay-level-8" data-transition="fade">
                    <asp:Image runat="server" 
                        ID="imgAuthor"
                        alt=""
                        data-bgposition="center center"
                        data-bgfit="cover"
                        data-bgrepeat="no-repeat"
                        class="rev-slidebg" />

                    <h1 class="tp-caption font-weight-extra-bold text-color-light negative-ls-2"
                        data-frames='[{"delay":700,"speed":2000,"frame":"0","from":"sX:1.5;opacity:0;fb:0px;","to":"o:1;fb:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
                        data-x="center"
                        data-y="center"
                        data-fontsize="['40','55','90','95']"
                        data-lineheight="['55','55','90','95']"
                        style="top: -25px">
                        <asp:Label ID="lblAuthorName" runat="server"></asp:Label></h1>

                    <a class="tp-caption btn btn-rounded-icon text-color-light"
                        style="display: inline-flex !important"
                        data-frames='[{"delay":1000,"speed":2500,"frame":"0","from":"sX:1.5;opacity:0;fb:20px;","to":"o:1;fb:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
                        href="#main"
                        data-has=""
                        data-hash-offset="150"
                        data-x="center"
                        data-y="center" data-voffset="['65','65','-150','-400']"
                        data-fontsize="['18','25','40','50']"><i class="icon-arrow-down icons"></i></a>

                    <div class="tp-caption"
                        style="left: -5px; background-color: #FFF; min-height: 125px;"
                        data-frames='[{"delay":0,"from":"skY:-3deg;","to":"o:1","ease":"Power3.easeInOut"}]'
                        data-x="center"
                        data-y="bottom" data-voffset="-80"
                        data-width="103%"
                        data-basealign="slide">
                    </div>
                </li>
            </ul>
        </div>
    </div>
    <div class="container-fluid pl-5 pr-5 pt-0" id="main">
        <div class="row mb-5 ml-0 mr-0 d-flex">
            <div class="col-md-12 d-flex justify-content-center">
                <span><i class="icon-location-pin icons"></i>
                    <asp:Label runat="server" ID="lblBirthplace" CssClass="pl-2 text-dark text-3"></asp:Label></span>
                <span class="ml-4"><i class="far fa-calendar"></i>
                    <asp:Label runat="server" ID="lblAuthorDOB" CssClass="pl-2 text-dark text-3"></asp:Label></span>
                <span class="ml-4"><i class="fas fa-briefcase"></i>
                    <asp:Label runat="server" ID="lblOccupation" CssClass="pl-2 text-dark text-3"></asp:Label></span>
            </div>
            <div class="col-md-10 offset-1 d-flex justify-content-center text-justify pt-4 font-weight-bold">
                <span>
                    <asp:Label runat="server" ID="lblRemarks" CssClass="pl-2 text-dark text-3"></asp:Label>
                </span>
            </div>
        </div>
        <hr class="gradient"/>
        <div class="row">
            <div class="col-md-9 sort-destination-loader pt-2 sort-destination-loader-loaded">
                <div class="card-columns">
                    <asp:Repeater ID="rpAuthorQuote" runat="server">
                        <ItemTemplate>
                            <div class="card quoteCard pl-3 pr-3 pt-3 text-left appear-animation animated fadeInRight appear-animation-visible" data-appear-animation="fadeInRight" data-appear-animation-delay="0" data-appear-animation-duration="3s" style="animation-duration: 3s; animation-delay: 0ms;">
                                <article class="post post-small p-2">
                                    <div class="post-content">
                                        <blockquote class="blockquote-primary">
                                            <p class="text-dark text-4">
                                                <i class="fa fa-quote-left text-dark pr-1"></i>
                                                <asp:Label ID="Label1" Text='<%# Eval("Quote").ToString() %>' runat="server"></asp:Label>
                                            </p>
                                        </blockquote>
                                        <div class="post-meta pl-2">
                                            <div>
                                                <span><i class="far fa-folder"></i>
                                                    <asp:HyperLink ID="hlCategory" runat="server" NavigateUrl='<%# "~/quotes/"+Eval("CategoryURL").ToString() %>' Text='<%# Eval("CategoryName").ToString() %>' ToolTip='<%# Eval("CategoryName").ToString()+" quotes" %>'></asp:HyperLink></span>

                                            </div>
                                            <div>
                                                <span><i class="far fa-calendar"></i>
                                                    <asp:Label runat="server" CssClass="pl-1 text-primary" Text='<%# Eval("Created").ToString() %>'></asp:Label></span>
                                                <br />
                                            </div>
                                            <span class="social-icons-whatsapp text-4 pt-3 pl-5 ml-3"><a href="https://www.whatsapp.com/" target="_blank" title="Whatsapp"><i class="fab fa-whatsapp"></i></a></span>
                                            <span class="social-icons-instagram text-4 pl-1 pr-1"><a href="https://www.instagram.com/" target="_blank" title="Instagram"><i class="fab fa-instagram"></i></a></span>
                                            <span class="social-icons-facebook text-4 pl-1 pr-1"><a href="http://www.facebook.com/" target="_blank" title="Facebook"><i class="fab fa-facebook-f"></i></a></span>
                                            <span class="social-icons-twitter text-4 pl-1 pr-1"><a href="http://www.twitter.com/" target="_blank" title="Twitter"><i class="fab fa-twitter"></i></a></span>
                                            <span><a href="#"><i class="far fa-copy text-4 pl-1 pr-1"></i></a></span>
                                            <span><a href="#"><i class="fas fa-download text-4 pl-1 pr-1"></i></a></span>
                                        </div>
                                    </div>
                                </article>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <div class="col-md-3 sticky-container">
                <div class="col-md-12 col-lg-12 mb-5 mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="800" style="animation-delay: 800ms;">
                    <div class="card flip-card flip-card-3d text-center rounded-3">
                        <div class="flip-front p-5">
                            <div class="flip-content my-4">
                                <strong class="font-weight-extra-bold text-color-dark line-height-1 text-7 mb-3 d-inline-block">Popular Categories</strong>
                                <h4 class="font-weight-bold text-color-primary text-4"></h4>
                                <p class="mt-3 p-3">Inspiration, Life Favourite, Misc, etc . . .</p>
                            </div>
                        </div>
                        <div class="flip-back">
                            <div class="flip-content">
                                <h4 class="font-weight-bold text-color-dark d-inline-block text-center">Categories</h4>
                                <div class="row">
                                    <div class="col-md-9 offset-3 pl-0">
                                        <asp:Repeater ID="rpCategory" runat="server">
                                            <ItemTemplate>
                                                <p class="font-weight-light text-color-light text-left mb-2 mt-1">
                                                    <asp:HyperLink runat="server" NavigateUrl='<%# "~/quotes/" + Eval("CategoryURL").ToString() %>' CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">
                                                    <%# Eval("CategoryName") %> 
                                                    <span><i class="fas fa-chevron-right"></i></span>
                                                    </asp:HyperLink>
                                                </p>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <p class="font-weight-light text-color-light text-right mt-3 mb-2">
                                            <asp:HyperLink runat="server" NavigateUrl="~/ClientPanel/AllCategories.aspx" CssClass="text-tertiary p-1 pl-3 pr-2">View More                                    
                                            <span><i class="fas fa-chevron-right"></i></span>
                                            </asp:HyperLink>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-12 col-lg-12 mt-4 mb-5 mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="800" style="animation-delay: 800ms;">
                    <div class="card flip-card flip-card-3d text-center rounded-3">
                        <div class="flip-front p-5">
                            <div class="flip-content my-4">
                                <strong class="font-weight-extra-bold text-color-dark line-height-1 text-7 mb-3 d-inline-block">Popular
                            <br />
                                    Authors</strong>
                                <h4 class="font-weight-bold text-color-primary text-4"></h4>
                                <p class="mt-3 p-3">Albert Einstein, Confucius, Friedrich Nietzsche, etc . . .</p>
                            </div>
                        </div>
                        <div class="flip-back">
                            <div class="flip-content">
                                <h4 class="font-weight-bold text-color-dark d-inline-block text-center">Authors</h4>
                                <div class="row">
                                    <div class="col-md-9 offset-3 pl-0">
                                        <asp:Repeater ID="rpAuthor" runat="server">
                                            <ItemTemplate>
                                                <p class="font-weight-light text-color-light text-left mb-2 mt-1 <%# Container.ItemIndex < 3 %>">
                                                    <asp:HyperLink runat="server" NavigateUrl='<%# "~/" + Eval("AuthorURL").ToString()+"/Quotes"%>' CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">
                                                    <%# Eval("AuthorName") %> 
                                                    <span><i class="fas fa-chevron-right"></i></span>
                                                    </asp:HyperLink>
                                                </p>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                        <p class="font-weight-light text-color-light text-right mt-3 mb-2">
                                            <asp:HyperLink runat="server" NavigateUrl="~/" CssClass="text-tertiary p-1 pl-3 pr-2">View More                                    
                                            <span><i class="fas fa-chevron-right"></i></span>
                                            </asp:HyperLink>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-12 col-lg-12 mt-4 mb-5 mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="800" style="animation-delay: 800ms;">
                    <div class="card flip-card flip-card-3d text-center rounded-3">
                        <div class="flip-front p-5">
                            <div class="flip-content my-4">
                                <strong class="font-weight-extra-bold text-color-dark line-height-1 text-7 mb-3 d-inline-block">Popular
                            <br />
                                    Moods</strong>
                                <h4 class="font-weight-bold text-color-primary text-4"></h4>
                                <p class="mt-3 p-3">Failure, Happiness, Love Favourite, etc . . .</p>
                            </div>
                        </div>
                        <div class="flip-back">
                            <div class="flip-content">
                                <h4 class="font-weight-bold text-color-dark d-inline-block text-center">Moods</h4>
                                <div class="row">
                                    <div class="col-md-9 offset-3 pl-0">
                                        <p class="font-weight-light text-color-light text-left mb-2 mt-1">
                                            <asp:HyperLink runat="server" NavigateUrl="~/ClientPanel/Inspirational.aspx" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Failure
                                            <span><i class="fas fa-chevron-right"></i></span>
                                            </asp:HyperLink>
                                        </p>
                                        <p class="font-weight-light text-color-light text-left mb-2">
                                            <asp:HyperLink runat="server" NavigateUrl="/" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Happiness
                                            <span><i class="fas fa-chevron-right"></i></span>
                                            </asp:HyperLink>
                                        </p>
                                        <p class="font-weight-light text-color-light text-left mb-2">
                                            <asp:HyperLink runat="server" NavigateUrl="/" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Love Favourite
                                            <span><i class="fas fa-chevron-right"></i></span>
                                            </asp:HyperLink>
                                        </p>
                                        <p class="font-weight-light text-color-light text-left mb-2">
                                            <asp:HyperLink runat="server" NavigateUrl="/" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Sorry
                                            <span><i class="fas fa-chevron-right"></i></span>
                                            </asp:HyperLink>
                                        </p>
                                        <p class="font-weight-light text-color-light text-right mt-3 mb-2">
                                            <asp:HyperLink runat="server" NavigateUrl="/" CssClass="text-tertiary p-1 pl-3 pr-2">View More                                    
                                            <span><i class="fas fa-chevron-right"></i></span>
                                            </asp:HyperLink>
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

