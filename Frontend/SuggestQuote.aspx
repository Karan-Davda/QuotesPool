<%@ Page Title="" Language="C#" MasterPageFile="~/Content/QuotesPoolMaster.master" AutoEventWireup="true" CodeFile="SuggestQuote.aspx.cs" Inherits="Frontend_SuggestQuote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="Server">
    <div class="slider-container rev_slider_wrapper" style="margin-top: 0px; margin-bottom: 0px; position: absolute; max-height: 430px; overflow: visible; height: 430px; width: 200px; left: 0px;">
        <div id="revolutionSlider" class="slider rev_slider" data-version="5.4.8" style="height: 422px">
            <ul>
                <li class="slide-overlay slide-overlay-level-8" data-transition="fade">
                    <img src="<%=ResolveUrl("~/Content/img/SuggestQuote.jpg") %>"
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
                        style="top: -25px">Suggest Quote</h1>

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
    <div class="container-fluid pl-5 pr-5 pt-0 d-flex" id="main">
        <div class="col-lg-6 offset-3">

            <div class="overflow-hidden mb-5">
                <h2 class="font-weight-normal text-7 mt-2 mb-0 appear-animation animated maskUp appear-animation-visible" data-appear-animation="maskUp" data-appear-animation-delay="200" style="animation-delay: 200ms;"><strong class="font-weight-extra-bold">Suggest</strong> Us a Quote</h2>
            </div>

            <div id="contactForm" class="contact-form shadow-lg rounded-lg p-5">
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label class="font-weight-bold text-dark text-2">Name <span class="text-danger">*</span></label>
                        <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Enter your Name" ForeColor="Red" ControlToValidate="txtName" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group col-md-6">
                        <label class="font-weight-bold text-dark text-2">Email <span class="text-danger">*</span></label>
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Enter your Email" ForeColor="Red" ControlToValidate="txtEmail" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="reEmail" runat="server" ErrorMessage="Enter valid email" ForeColor="Red" ControlToValidate="txtEmail" SetFocusOnError="true" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col">
                        <label class="font-weight-bold text-dark text-2">Quote <span class="text-danger">*</span></label>
                        <asp:TextBox runat="server" CssClass="form-control" ID="txtQuote" Rows="4" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvQuote" runat="server" ErrorMessage="Enter a Quote" ForeColor="Red" ControlToValidate="txtQuote" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-lg-4">
                        <label class="font-weight-bold text-dark text-2">Author Name <span class="text-danger">*</span></label>
                        <asp:TextBox runat="server" CssClass="form-control" ID="txtAuthorName"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvAuthorName" runat="server" ErrorMessage="Enter Author Name" ForeColor="Red" ControlToValidate="txtAuthorName" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group col-lg-4">
                        <label class="font-weight-bold text-dark text-2">Category <span class="text-danger">*</span></label>
                        <asp:TextBox runat="server" CssClass="form-control" ID="txtCategory"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCategory" runat="server" ErrorMessage="Enter a catgeory" ForeColor="Red" ControlToValidate="txtCategory" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group col-lg-4">
                        <label class="font-weight-bold text-dark text-2">Ocassion</label>
                        <asp:TextBox runat="server" CssClass="form-control" ID="txtOcassion"></asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-2 offset-4">
                        <asp:Button runat="server" CssClass="btn btn-success btn-modern btn-rounded" Text="Submit" />
                    </div>
                    <div class="form-group col-md-2">
                        <a class="btn btn-primary btn-modern btn-rounded" href='<%= ResolveUrl("~/") %>'><i class="icon-home icons font-weight-bold text-4 text-light"></i></a>
                    </div>
                </div>

            </div>

        </div>
    </div>
</asp:Content>

