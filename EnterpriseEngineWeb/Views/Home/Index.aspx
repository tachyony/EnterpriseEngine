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
    <td><asp:RadioButton ID="RadioButtonYes1_1" runat="server" Text="Yes" GroupName="Group1" /> <asp:RadioButton ID="RadioButtonNo1_1" runat="server" Text="No" GroupName="Group1" Checked="True" /></td>
    <td><asp:RadioButton ID="RadioButton1" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton2" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton3" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton4" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton5" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton6" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton7" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton8" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton9" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton10" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton11" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton12" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton13" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton14" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton15" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton16" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton17" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton18" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton19" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton20" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton21" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton22" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton23" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton24" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton25" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton26" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton27" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton28" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton29" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton30" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton31" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton32" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton33" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton34" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton35" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton36" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton37" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton38" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton39" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton40" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton41" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton42" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton43" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton44" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton45" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton46" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton47" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton48" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton49" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton50" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton51" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton52" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton53" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton54" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton55" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton56" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton57" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton58" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton59" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton60" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton61" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton62" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton63" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton64" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton65" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton66" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton67" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton68" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton69" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton70" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton71" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton72" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton73" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton74" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton75" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton76" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton77" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton78" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton79" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton80" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton81" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton82" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton83" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton84" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton85" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton86" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton87" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton88" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton89" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton90" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton91" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton92" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton93" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton94" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton95" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton96" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton97" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton98" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton99" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton100" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton101" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton102" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton103" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton104" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton105" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton106" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton107" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton108" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton109" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton110" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton111" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton112" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton113" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton114" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton115" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton116" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton117" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton118" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton119" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton120" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton121" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton122" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton123" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton124" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton125" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton126" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton127" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton128" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton129" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton130" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton131" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton132" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton133" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton134" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton135" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton136" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton137" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton138" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton139" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton140" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton141" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton142" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton143" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton144" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton145" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton146" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton147" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton148" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton149" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton150" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton151" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton152" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton153" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton154" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton155" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton156" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton157" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton158" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton159" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton160" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton161" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton162" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton163" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton164" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton165" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton166" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton167" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton168" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton169" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton170" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton171" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton172" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton173" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton174" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton175" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton176" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton177" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton178" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton179" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton180" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton181" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton182" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton183" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton184" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton185" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton186" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton187" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton188" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton189" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton190" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton191" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton192" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton193" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton194" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton195" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton196" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton197" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton198" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton199" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton200" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton201" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton202" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton203" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton204" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton205" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton206" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton207" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton208" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton209" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton210" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton211" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton212" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton213" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton214" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton215" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton216" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton217" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton218" runat="server" Text="No" /></td>
    </tr>
    <tr>
    <td><asp:RadioButton ID="RadioButton219" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton220" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton221" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton222" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton223" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton224" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton225" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton226" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton227" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton228" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton229" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton230" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton231" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton232" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton233" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton234" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton235" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton236" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton237" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton238" runat="server" Text="No" /></td>
    <td><asp:RadioButton ID="RadioButton239" runat="server" Text="Yes" /> <asp:RadioButton ID="RadioButton240" runat="server" Text="No" /></td>
    </tr>
    </table>
    <p>Enter a word: <input type="text" id="TheWord" runat="server" /></p>
    <p><input type="submit" runat="server" id="Submit" value="Submit" /></p>
    </form>
</asp:Content>
