<%@ Page Title="" Language="C#" MasterPageFile="~/Content/QuotesPoolMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <div class="slider-container rev_slider_wrapper" style="margin-top: 0px; margin-bottom: 0px; position: absolute; max-height: 430px; overflow: visible; height: 430px; width: 200px; left: 0px;">
        <div id="revolutionSlider" class="slider rev_slider" data-version="5.4.8" style="height: 422px">
            <ul>
                <li class="slide-overlay slide-overlay-level-8" data-transition="fade">
                    <img src="<%=ResolveUrl("~/Content/img/books.jpg") %>"
                        alt=""
                        data-bgposition="center center"
                        data-bgfit="cover"
                        data-bgrepeat="no-repeat"
                        class="rev-slidebg">

                    <h1 class="tp-caption font-weight-extra-bold text-color-light negative-ls-2"
                        data-frames='[{"delay":700,"speed":2000,"frame":"0","from":"sX:1.5;opacity:0;fb:0px;","to":"o:1;fb:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
                        data-x="center"
                        data-y="center"
                        data-fontsize="['40','55','90','95']"
                        data-lineheight="['55','55','90','95']"
                        style="top: -25px">Welcome to Quotes Pool</h1>

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
        <div class="row" data-appear-animation="fadeInLeftShorter" data-appear-animation-delay="800">
            <div class="col-md-3 col-lg-3 ml-5 mb-5 mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="600" style="animation-delay: 600ms;">
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
                                        <asp:HyperLink runat="server" NavigateUrl="~/Frontend/Category.aspx" CssClass="text-tertiary p-1 pl-3 pr-2">View More                                    
                                            <span><i class="fas fa-chevron-right"></i></span>
                                        </asp:HyperLink>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-3 col-lg-3 offset-1 mb-5 mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="600" style="animation-delay: 600ms;">
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

            <div class="col-md-3 col-lg-3 offset-1 mb-5 mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="600" style="animation-delay: 600ms;">
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
        <div class="row mt-5 mb-5" data-appear-animation="fadeInLeftShorter" data-appear-animation-delay="400">
            <div class="col-md-3 col-lg-3 ml-5  mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="600" style="animation-delay: 600ms;">
                <div class="card flip-card flip-card-3d text-center rounded-3">
                    <div class="flip-front p-5">
                        <div class="flip-content my-4">
                            <strong class="font-weight-extra-bold text-color-dark line-height-1 text-7 mb-3 d-inline-block">Popular Ocassions</strong>
                            <h4 class="font-weight-bold text-color-primary text-4"></h4>
                            <p class="mt-3 p-3">Anniversary, Birthday, Death, etc . . .</p>
                        </div>
                    </div>
                    <div class="flip-back">
                        <div class="flip-content">
                            <h4 class="font-weight-bold text-color-dark d-inline-block text-center">Ocassions</h4>
                            <div class="row">
                                <div class="col-md-9 offset-3 pl-0">
                                    <p class="font-weight-light text-color-light text-left mb-2 mt-1">
                                        <asp:HyperLink runat="server" NavigateUrl="~/ClientPanel/Inspirational.aspx" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Anniversary
                                            <span><i class="fas fa-chevron-right"></i></span>
                                        </asp:HyperLink>
                                    </p>
                                    <p class="font-weight-light text-color-light text-left mb-2">
                                        <asp:HyperLink runat="server" NavigateUrl="/" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Birthday
                                            <span><i class="fas fa-chevron-right"></i></span>
                                        </asp:HyperLink>
                                    </p>
                                    <p class="font-weight-light text-color-light text-left mb-2">
                                        <asp:HyperLink runat="server" NavigateUrl="/" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Death
                                            <span><i class="fas fa-chevron-right"></i></span>
                                        </asp:HyperLink>
                                    </p>
                                    <p class="font-weight-light text-color-light text-left mb-2">
                                        <asp:HyperLink runat="server" NavigateUrl="/" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Father's Day
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

            <div class="col-md-3 col-lg-3 offset-1 mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="600" style="animation-delay: 600ms;">
                <div class="card flip-card flip-card-3d text-center rounded-3">
                    <div class="flip-front p-5">
                        <div class="flip-content my-4">
                            <strong class="font-weight-extra-bold text-color-dark line-height-1 text-7 mb-3 d-inline-block">Festival Quotes</strong>
                            <h4 class="font-weight-bold text-color-primary text-4"></h4>
                            <p class="mt-3 p-3">Eid Mubarak, etc . . .</p>
                        </div>
                    </div>
                    <div class="flip-back">
                        <div class="flip-content">
                            <h4 class="font-weight-bold text-color-dark d-inline-block text-center">Festival</h4>
                            <div class="row">
                                <div class="col-md-9 offset-3 pl-0">
                                    <p class="font-weight-light text-color-light text-left mb-2 mt-1">
                                        <asp:HyperLink runat="server" NavigateUrl="~/ClientPanel/EidMubaarak.aspx" CssClass="btn btn-outline btn-rounded btn-tertiary btn-with-arrow p-1 pl-3 pr-2">Eid Mubarak
                                            <span><i class="fas fa-chevron-right"></i></span>
                                        </asp:HyperLink>
                                    </p>
                                    <p class="font-weight-light text-color-light text-right mt-3 mb-2 align-self-end">
                                        <asp:HyperLink runat="server" CssClass="text-tertiary p-1 pl-3 pr-2">View More                                    
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

        <div class="row mt-5 mb-5" data-appear-animation="fadeInLeftShorter" data-appear-animation-delay="400" runat="server" visible="false">
            <div class="col-md-8 offset-2 col-lg-8 mb-lg-0 appear-animation animated fadeInUpShorter appear-animation-visible shadow-lg" data-appear-animation="fadeInUpShorter" data-appear-animation-delay="400" style="animation-delay: 400ms;">

                <div class="card card-background-image-hover border-0" style="background-image: url(img/blog/square/blog-1.jpg);">
                    <div class="card-body text-center p-5">
                        <h3 class="card-title mt-1 mb-2 text-5 font-weight-bold">Today's Quote</h3>
                        <blockquote class="quote-card">
                            <p class="pt-4 text-5">
                                We first make our habits, and then our habits make us. 
                            </p>
                        </blockquote>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

