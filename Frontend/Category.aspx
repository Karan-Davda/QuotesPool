<%@ Page Title="" Language="C#" MasterPageFile="~/Content/QuotesPoolMaster.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Frontend_Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <div class="slider-container rev_slider_wrapper" style="margin-top: 0px; margin-bottom: 0px; position: absolute; max-height: 430px; overflow: visible; height: 430px; width: 200px; left: 0px;">
        <div id="revolutionSlider" class="slider rev_slider" data-version="5.4.8" style="height: 422px">
            <ul>
                <li class="slide-overlay slide-overlay-level-8" data-transition="fade">
                    <img src="<%=ResolveUrl("~/Content/img/categories.jpg") %>"
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
                        style="top: -25px">Quotes By Category</h1>

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
            <div class="col-md-2 text-right">
                <span runat="server" id="imgDescription" cssclass="img-fluid rounded" height="60px"><i class="fas fa-sitemap text-6"></i></span>
            </div>
            <div class="col-md-10 d-flex align-items-center">
                <asp:Label runat="server" ID="lblDescription" CssClass="text-tertiary text-4 font-weight-semibold">
                   “ Want a Quote from A Specific Topic? Enjoy our quote collection organized by categories to help you to get perfect quote. ”
                </asp:Label>
            </div>
        </div>
        <hr class="gradient" />

    </div>
    <div class="container">
        <div class="row pl-5">

            <asp:Repeater ID="rpCategory" runat="server">
                <ItemTemplate>
                    <div class="col-md-4 mt-2">
                        <h4 class="btn default button-next circle">
                            <asp:HyperLink ID="hlCategory" CssClass="text-Primary text-4" runat="server" ToolTip='<%# Eval("CategoryName") + "  questions and answers" %>' NavigateUrl='<%# "~/quotes/" + Eval("CategoryURL").ToString() %>' Text='<%# Eval("CategoryName") %>'></asp:HyperLink>
                        </h4>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>

