<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page - Enterprise Engine
</asp:Content>
<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Home Page.</h1>
                <h2><%: ViewBag.Message %></h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Decision engine</h3>
    <form method="post" action="EngineResult" runat="server" name="Form" id="Form">
    <p>Enter you question: <input type="text" runat="server" id="question" /></p>
    <h3>Engine configuration</h3>
    <p>Configure the rules for decision:</p>
    <table ID="EngineTable" style="width:1000px;">
    <tr>
    <th>Set 01:</th>
    <th>Set 02:</th>
    <th>Set 03:</th>
    <th>Set 04:</th>
    <th>Set 05:</th>
    <th>Set 06:</th>
    <th>Set 07:</th>
    <th>Set 08:</th>
    <th>Set 09:</th>
    <th>Set 10:</th>
    <th>Set 11:</th>
    </tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes0" runat="server" Text="Yes" GroupName="Group0" /> <asp:RadioButton ID="RadioButtonNo0" runat="server" Text="No" GroupName="Group0" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes1" runat="server" Text="Yes" GroupName="Group1" /> <asp:RadioButton ID="RadioButtonNo1" runat="server" Text="No" GroupName="Group1" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes2" runat="server" Text="Yes" GroupName="Group2" /> <asp:RadioButton ID="RadioButtonNo2" runat="server" Text="No" GroupName="Group2" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes3" runat="server" Text="Yes" GroupName="Group3" /> <asp:RadioButton ID="RadioButtonNo3" runat="server" Text="No" GroupName="Group3" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes4" runat="server" Text="Yes" GroupName="Group4" /> <asp:RadioButton ID="RadioButtonNo4" runat="server" Text="No" GroupName="Group4" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes5" runat="server" Text="Yes" GroupName="Group5" /> <asp:RadioButton ID="RadioButtonNo5" runat="server" Text="No" GroupName="Group5" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes6" runat="server" Text="Yes" GroupName="Group6" /> <asp:RadioButton ID="RadioButtonNo6" runat="server" Text="No" GroupName="Group6" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes7" runat="server" Text="Yes" GroupName="Group7" /> <asp:RadioButton ID="RadioButtonNo7" runat="server" Text="No" GroupName="Group7" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes8" runat="server" Text="Yes" GroupName="Group8" /> <asp:RadioButton ID="RadioButtonNo8" runat="server" Text="No" GroupName="Group8" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes9" runat="server" Text="Yes" GroupName="Group9" /> <asp:RadioButton ID="RadioButtonNo9" runat="server" Text="No" GroupName="Group9" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes10" runat="server" Text="Yes" GroupName="Group10" /> <asp:RadioButton ID="RadioButtonNo10" runat="server" Text="No" GroupName="Group10" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes11" runat="server" Text="Yes" GroupName="Group11" /> <asp:RadioButton ID="RadioButtonNo11" runat="server" Text="No" GroupName="Group11" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes12" runat="server" Text="Yes" GroupName="Group12" /> <asp:RadioButton ID="RadioButtonNo12" runat="server" Text="No" GroupName="Group12" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes13" runat="server" Text="Yes" GroupName="Group13" /> <asp:RadioButton ID="RadioButtonNo13" runat="server" Text="No" GroupName="Group13" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes14" runat="server" Text="Yes" GroupName="Group14" /> <asp:RadioButton ID="RadioButtonNo14" runat="server" Text="No" GroupName="Group14" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes15" runat="server" Text="Yes" GroupName="Group15" /> <asp:RadioButton ID="RadioButtonNo15" runat="server" Text="No" GroupName="Group15" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes16" runat="server" Text="Yes" GroupName="Group16" /> <asp:RadioButton ID="RadioButtonNo16" runat="server" Text="No" GroupName="Group16" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes17" runat="server" Text="Yes" GroupName="Group17" /> <asp:RadioButton ID="RadioButtonNo17" runat="server" Text="No" GroupName="Group17" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes18" runat="server" Text="Yes" GroupName="Group18" /> <asp:RadioButton ID="RadioButtonNo18" runat="server" Text="No" GroupName="Group18" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes19" runat="server" Text="Yes" GroupName="Group19" /> <asp:RadioButton ID="RadioButtonNo19" runat="server" Text="No" GroupName="Group19" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes20" runat="server" Text="Yes" GroupName="Group20" /> <asp:RadioButton ID="RadioButtonNo20" runat="server" Text="No" GroupName="Group20" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes21" runat="server" Text="Yes" GroupName="Group21" /> <asp:RadioButton ID="RadioButtonNo21" runat="server" Text="No" GroupName="Group21" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes22" runat="server" Text="Yes" GroupName="Group22" /> <asp:RadioButton ID="RadioButtonNo22" runat="server" Text="No" GroupName="Group22" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes23" runat="server" Text="Yes" GroupName="Group23" /> <asp:RadioButton ID="RadioButtonNo23" runat="server" Text="No" GroupName="Group23" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes24" runat="server" Text="Yes" GroupName="Group24" /> <asp:RadioButton ID="RadioButtonNo24" runat="server" Text="No" GroupName="Group24" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes25" runat="server" Text="Yes" GroupName="Group25" /> <asp:RadioButton ID="RadioButtonNo25" runat="server" Text="No" GroupName="Group25" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes26" runat="server" Text="Yes" GroupName="Group26" /> <asp:RadioButton ID="RadioButtonNo26" runat="server" Text="No" GroupName="Group26" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes27" runat="server" Text="Yes" GroupName="Group27" /> <asp:RadioButton ID="RadioButtonNo27" runat="server" Text="No" GroupName="Group27" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes28" runat="server" Text="Yes" GroupName="Group28" /> <asp:RadioButton ID="RadioButtonNo28" runat="server" Text="No" GroupName="Group28" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes29" runat="server" Text="Yes" GroupName="Group29" /> <asp:RadioButton ID="RadioButtonNo29" runat="server" Text="No" GroupName="Group29" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes30" runat="server" Text="Yes" GroupName="Group30" /> <asp:RadioButton ID="RadioButtonNo30" runat="server" Text="No" GroupName="Group30" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes31" runat="server" Text="Yes" GroupName="Group31" /> <asp:RadioButton ID="RadioButtonNo31" runat="server" Text="No" GroupName="Group31" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes32" runat="server" Text="Yes" GroupName="Group32" /> <asp:RadioButton ID="RadioButtonNo32" runat="server" Text="No" GroupName="Group32" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes33" runat="server" Text="Yes" GroupName="Group33" /> <asp:RadioButton ID="RadioButtonNo33" runat="server" Text="No" GroupName="Group33" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes34" runat="server" Text="Yes" GroupName="Group34" /> <asp:RadioButton ID="RadioButtonNo34" runat="server" Text="No" GroupName="Group34" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes35" runat="server" Text="Yes" GroupName="Group35" /> <asp:RadioButton ID="RadioButtonNo35" runat="server" Text="No" GroupName="Group35" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes36" runat="server" Text="Yes" GroupName="Group36" /> <asp:RadioButton ID="RadioButtonNo36" runat="server" Text="No" GroupName="Group36" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes37" runat="server" Text="Yes" GroupName="Group37" /> <asp:RadioButton ID="RadioButtonNo37" runat="server" Text="No" GroupName="Group37" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes38" runat="server" Text="Yes" GroupName="Group38" /> <asp:RadioButton ID="RadioButtonNo38" runat="server" Text="No" GroupName="Group38" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes39" runat="server" Text="Yes" GroupName="Group39" /> <asp:RadioButton ID="RadioButtonNo39" runat="server" Text="No" GroupName="Group39" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes40" runat="server" Text="Yes" GroupName="Group40" /> <asp:RadioButton ID="RadioButtonNo40" runat="server" Text="No" GroupName="Group40" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes41" runat="server" Text="Yes" GroupName="Group41" /> <asp:RadioButton ID="RadioButtonNo41" runat="server" Text="No" GroupName="Group41" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes42" runat="server" Text="Yes" GroupName="Group42" /> <asp:RadioButton ID="RadioButtonNo42" runat="server" Text="No" GroupName="Group42" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes43" runat="server" Text="Yes" GroupName="Group43" /> <asp:RadioButton ID="RadioButtonNo43" runat="server" Text="No" GroupName="Group43" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes44" runat="server" Text="Yes" GroupName="Group44" /> <asp:RadioButton ID="RadioButtonNo44" runat="server" Text="No" GroupName="Group44" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes45" runat="server" Text="Yes" GroupName="Group45" /> <asp:RadioButton ID="RadioButtonNo45" runat="server" Text="No" GroupName="Group45" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes46" runat="server" Text="Yes" GroupName="Group46" /> <asp:RadioButton ID="RadioButtonNo46" runat="server" Text="No" GroupName="Group46" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes47" runat="server" Text="Yes" GroupName="Group47" /> <asp:RadioButton ID="RadioButtonNo47" runat="server" Text="No" GroupName="Group47" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes48" runat="server" Text="Yes" GroupName="Group48" /> <asp:RadioButton ID="RadioButtonNo48" runat="server" Text="No" GroupName="Group48" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes49" runat="server" Text="Yes" GroupName="Group49" /> <asp:RadioButton ID="RadioButtonNo49" runat="server" Text="No" GroupName="Group49" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes50" runat="server" Text="Yes" GroupName="Group50" /> <asp:RadioButton ID="RadioButtonNo50" runat="server" Text="No" GroupName="Group50" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes51" runat="server" Text="Yes" GroupName="Group51" /> <asp:RadioButton ID="RadioButtonNo51" runat="server" Text="No" GroupName="Group51" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes52" runat="server" Text="Yes" GroupName="Group52" /> <asp:RadioButton ID="RadioButtonNo52" runat="server" Text="No" GroupName="Group52" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes53" runat="server" Text="Yes" GroupName="Group53" /> <asp:RadioButton ID="RadioButtonNo53" runat="server" Text="No" GroupName="Group53" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes54" runat="server" Text="Yes" GroupName="Group54" /> <asp:RadioButton ID="RadioButtonNo54" runat="server" Text="No" GroupName="Group54" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes55" runat="server" Text="Yes" GroupName="Group55" /> <asp:RadioButton ID="RadioButtonNo55" runat="server" Text="No" GroupName="Group55" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes56" runat="server" Text="Yes" GroupName="Group56" /> <asp:RadioButton ID="RadioButtonNo56" runat="server" Text="No" GroupName="Group56" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes57" runat="server" Text="Yes" GroupName="Group57" /> <asp:RadioButton ID="RadioButtonNo57" runat="server" Text="No" GroupName="Group57" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes58" runat="server" Text="Yes" GroupName="Group58" /> <asp:RadioButton ID="RadioButtonNo58" runat="server" Text="No" GroupName="Group58" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes59" runat="server" Text="Yes" GroupName="Group59" /> <asp:RadioButton ID="RadioButtonNo59" runat="server" Text="No" GroupName="Group59" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes60" runat="server" Text="Yes" GroupName="Group60" /> <asp:RadioButton ID="RadioButtonNo60" runat="server" Text="No" GroupName="Group60" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes61" runat="server" Text="Yes" GroupName="Group61" /> <asp:RadioButton ID="RadioButtonNo61" runat="server" Text="No" GroupName="Group61" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes62" runat="server" Text="Yes" GroupName="Group62" /> <asp:RadioButton ID="RadioButtonNo62" runat="server" Text="No" GroupName="Group62" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes63" runat="server" Text="Yes" GroupName="Group63" /> <asp:RadioButton ID="RadioButtonNo63" runat="server" Text="No" GroupName="Group63" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes64" runat="server" Text="Yes" GroupName="Group64" /> <asp:RadioButton ID="RadioButtonNo64" runat="server" Text="No" GroupName="Group64" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes65" runat="server" Text="Yes" GroupName="Group65" /> <asp:RadioButton ID="RadioButtonNo65" runat="server" Text="No" GroupName="Group65" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes66" runat="server" Text="Yes" GroupName="Group66" /> <asp:RadioButton ID="RadioButtonNo66" runat="server" Text="No" GroupName="Group66" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes67" runat="server" Text="Yes" GroupName="Group67" /> <asp:RadioButton ID="RadioButtonNo67" runat="server" Text="No" GroupName="Group67" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes68" runat="server" Text="Yes" GroupName="Group68" /> <asp:RadioButton ID="RadioButtonNo68" runat="server" Text="No" GroupName="Group68" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes69" runat="server" Text="Yes" GroupName="Group69" /> <asp:RadioButton ID="RadioButtonNo69" runat="server" Text="No" GroupName="Group69" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes70" runat="server" Text="Yes" GroupName="Group70" /> <asp:RadioButton ID="RadioButtonNo70" runat="server" Text="No" GroupName="Group70" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes71" runat="server" Text="Yes" GroupName="Group71" /> <asp:RadioButton ID="RadioButtonNo71" runat="server" Text="No" GroupName="Group71" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes72" runat="server" Text="Yes" GroupName="Group72" /> <asp:RadioButton ID="RadioButtonNo72" runat="server" Text="No" GroupName="Group72" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes73" runat="server" Text="Yes" GroupName="Group73" /> <asp:RadioButton ID="RadioButtonNo73" runat="server" Text="No" GroupName="Group73" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes74" runat="server" Text="Yes" GroupName="Group74" /> <asp:RadioButton ID="RadioButtonNo74" runat="server" Text="No" GroupName="Group74" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes75" runat="server" Text="Yes" GroupName="Group75" /> <asp:RadioButton ID="RadioButtonNo75" runat="server" Text="No" GroupName="Group75" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes76" runat="server" Text="Yes" GroupName="Group76" /> <asp:RadioButton ID="RadioButtonNo76" runat="server" Text="No" GroupName="Group76" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes77" runat="server" Text="Yes" GroupName="Group77" /> <asp:RadioButton ID="RadioButtonNo77" runat="server" Text="No" GroupName="Group77" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes78" runat="server" Text="Yes" GroupName="Group78" /> <asp:RadioButton ID="RadioButtonNo78" runat="server" Text="No" GroupName="Group78" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes79" runat="server" Text="Yes" GroupName="Group79" /> <asp:RadioButton ID="RadioButtonNo79" runat="server" Text="No" GroupName="Group79" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes80" runat="server" Text="Yes" GroupName="Group80" /> <asp:RadioButton ID="RadioButtonNo80" runat="server" Text="No" GroupName="Group80" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes81" runat="server" Text="Yes" GroupName="Group81" /> <asp:RadioButton ID="RadioButtonNo81" runat="server" Text="No" GroupName="Group81" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes82" runat="server" Text="Yes" GroupName="Group82" /> <asp:RadioButton ID="RadioButtonNo82" runat="server" Text="No" GroupName="Group82" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes83" runat="server" Text="Yes" GroupName="Group83" /> <asp:RadioButton ID="RadioButtonNo83" runat="server" Text="No" GroupName="Group83" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes84" runat="server" Text="Yes" GroupName="Group84" /> <asp:RadioButton ID="RadioButtonNo84" runat="server" Text="No" GroupName="Group84" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes85" runat="server" Text="Yes" GroupName="Group85" /> <asp:RadioButton ID="RadioButtonNo85" runat="server" Text="No" GroupName="Group85" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes86" runat="server" Text="Yes" GroupName="Group86" /> <asp:RadioButton ID="RadioButtonNo86" runat="server" Text="No" GroupName="Group86" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes87" runat="server" Text="Yes" GroupName="Group87" /> <asp:RadioButton ID="RadioButtonNo87" runat="server" Text="No" GroupName="Group87" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes88" runat="server" Text="Yes" GroupName="Group88" /> <asp:RadioButton ID="RadioButtonNo88" runat="server" Text="No" GroupName="Group88" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes89" runat="server" Text="Yes" GroupName="Group89" /> <asp:RadioButton ID="RadioButtonNo89" runat="server" Text="No" GroupName="Group89" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes90" runat="server" Text="Yes" GroupName="Group90" /> <asp:RadioButton ID="RadioButtonNo90" runat="server" Text="No" GroupName="Group90" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes91" runat="server" Text="Yes" GroupName="Group91" /> <asp:RadioButton ID="RadioButtonNo91" runat="server" Text="No" GroupName="Group91" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes92" runat="server" Text="Yes" GroupName="Group92" /> <asp:RadioButton ID="RadioButtonNo92" runat="server" Text="No" GroupName="Group92" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes93" runat="server" Text="Yes" GroupName="Group93" /> <asp:RadioButton ID="RadioButtonNo93" runat="server" Text="No" GroupName="Group93" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes94" runat="server" Text="Yes" GroupName="Group94" /> <asp:RadioButton ID="RadioButtonNo94" runat="server" Text="No" GroupName="Group94" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes95" runat="server" Text="Yes" GroupName="Group95" /> <asp:RadioButton ID="RadioButtonNo95" runat="server" Text="No" GroupName="Group95" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes96" runat="server" Text="Yes" GroupName="Group96" /> <asp:RadioButton ID="RadioButtonNo96" runat="server" Text="No" GroupName="Group96" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes97" runat="server" Text="Yes" GroupName="Group97" /> <asp:RadioButton ID="RadioButtonNo97" runat="server" Text="No" GroupName="Group97" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes98" runat="server" Text="Yes" GroupName="Group98" /> <asp:RadioButton ID="RadioButtonNo98" runat="server" Text="No" GroupName="Group98" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes99" runat="server" Text="Yes" GroupName="Group99" /> <asp:RadioButton ID="RadioButtonNo99" runat="server" Text="No" GroupName="Group99" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes100" runat="server" Text="Yes" GroupName="Group100" /> <asp:RadioButton ID="RadioButtonNo100" runat="server" Text="No" GroupName="Group100" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes101" runat="server" Text="Yes" GroupName="Group101" /> <asp:RadioButton ID="RadioButtonNo101" runat="server" Text="No" GroupName="Group101" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes102" runat="server" Text="Yes" GroupName="Group102" /> <asp:RadioButton ID="RadioButtonNo102" runat="server" Text="No" GroupName="Group102" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes103" runat="server" Text="Yes" GroupName="Group103" /> <asp:RadioButton ID="RadioButtonNo103" runat="server" Text="No" GroupName="Group103" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes104" runat="server" Text="Yes" GroupName="Group104" /> <asp:RadioButton ID="RadioButtonNo104" runat="server" Text="No" GroupName="Group104" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes105" runat="server" Text="Yes" GroupName="Group105" /> <asp:RadioButton ID="RadioButtonNo105" runat="server" Text="No" GroupName="Group105" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes106" runat="server" Text="Yes" GroupName="Group106" /> <asp:RadioButton ID="RadioButtonNo106" runat="server" Text="No" GroupName="Group106" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes107" runat="server" Text="Yes" GroupName="Group107" /> <asp:RadioButton ID="RadioButtonNo107" runat="server" Text="No" GroupName="Group107" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes108" runat="server" Text="Yes" GroupName="Group108" /> <asp:RadioButton ID="RadioButtonNo108" runat="server" Text="No" GroupName="Group108" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes109" runat="server" Text="Yes" GroupName="Group109" /> <asp:RadioButton ID="RadioButtonNo109" runat="server" Text="No" GroupName="Group109" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes110" runat="server" Text="Yes" GroupName="Group110" /> <asp:RadioButton ID="RadioButtonNo110" runat="server" Text="No" GroupName="Group110" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes111" runat="server" Text="Yes" GroupName="Group111" /> <asp:RadioButton ID="RadioButtonNo111" runat="server" Text="No" GroupName="Group111" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes112" runat="server" Text="Yes" GroupName="Group112" /> <asp:RadioButton ID="RadioButtonNo112" runat="server" Text="No" GroupName="Group112" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes113" runat="server" Text="Yes" GroupName="Group113" /> <asp:RadioButton ID="RadioButtonNo113" runat="server" Text="No" GroupName="Group113" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes114" runat="server" Text="Yes" GroupName="Group114" /> <asp:RadioButton ID="RadioButtonNo114" runat="server" Text="No" GroupName="Group114" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes115" runat="server" Text="Yes" GroupName="Group115" /> <asp:RadioButton ID="RadioButtonNo115" runat="server" Text="No" GroupName="Group115" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes116" runat="server" Text="Yes" GroupName="Group116" /> <asp:RadioButton ID="RadioButtonNo116" runat="server" Text="No" GroupName="Group116" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes117" runat="server" Text="Yes" GroupName="Group117" /> <asp:RadioButton ID="RadioButtonNo117" runat="server" Text="No" GroupName="Group117" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes118" runat="server" Text="Yes" GroupName="Group118" /> <asp:RadioButton ID="RadioButtonNo118" runat="server" Text="No" GroupName="Group118" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes119" runat="server" Text="Yes" GroupName="Group119" /> <asp:RadioButton ID="RadioButtonNo119" runat="server" Text="No" GroupName="Group119" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes120" runat="server" Text="Yes" GroupName="Group120" /> <asp:RadioButton ID="RadioButtonNo120" runat="server" Text="No" GroupName="Group120" Checked="True" /></td>
</tr>
<tr>
<td><asp:RadioButton ID="RadioButtonYes121" runat="server" Text="Yes" GroupName="Group121" /> <asp:RadioButton ID="RadioButtonNo121" runat="server" Text="No" GroupName="Group121" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes122" runat="server" Text="Yes" GroupName="Group122" /> <asp:RadioButton ID="RadioButtonNo122" runat="server" Text="No" GroupName="Group122" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes123" runat="server" Text="Yes" GroupName="Group123" /> <asp:RadioButton ID="RadioButtonNo123" runat="server" Text="No" GroupName="Group123" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes124" runat="server" Text="Yes" GroupName="Group124" /> <asp:RadioButton ID="RadioButtonNo124" runat="server" Text="No" GroupName="Group124" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes125" runat="server" Text="Yes" GroupName="Group125" /> <asp:RadioButton ID="RadioButtonNo125" runat="server" Text="No" GroupName="Group125" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes126" runat="server" Text="Yes" GroupName="Group126" /> <asp:RadioButton ID="RadioButtonNo126" runat="server" Text="No" GroupName="Group126" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes127" runat="server" Text="Yes" GroupName="Group127" /> <asp:RadioButton ID="RadioButtonNo127" runat="server" Text="No" GroupName="Group127" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes128" runat="server" Text="Yes" GroupName="Group128" /> <asp:RadioButton ID="RadioButtonNo128" runat="server" Text="No" GroupName="Group128" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes129" runat="server" Text="Yes" GroupName="Group129" /> <asp:RadioButton ID="RadioButtonNo129" runat="server" Text="No" GroupName="Group129" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes130" runat="server" Text="Yes" GroupName="Group130" /> <asp:RadioButton ID="RadioButtonNo130" runat="server" Text="No" GroupName="Group130" Checked="True" /></td>
<td><asp:RadioButton ID="RadioButtonYes131" runat="server" Text="Yes" GroupName="Group131" /> <asp:RadioButton ID="RadioButtonNo131" runat="server" Text="No" GroupName="Group131" Checked="True" /></td>
</tr>
    </table>
    <p>Enter a word: <input type="text" id="TheWord" runat="server" /></p>
    <p><input type="submit" runat="server" id="Submit" value="Submit" /></p>
    </form>
</asp:Content>
