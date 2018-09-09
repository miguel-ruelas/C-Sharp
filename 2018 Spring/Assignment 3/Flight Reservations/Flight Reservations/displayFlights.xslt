<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html"/>


  <xsl:template match="/">
    <html>
      <head>
        <style type="text/css">
          td
          {
          text-align:center;
          vertical-align:middle;
          color:darkblue;
          border: 1px #cccccc;
          border-style: solid;
          background:f2f2f2;



          }
          tr th
          {
          background:#ccefff;
          border: 1px #cccccc;
          border-style: solid;

       
          }

          h1
          {
          color:black;
          }
          table
          {
          width:95%;
          }
          .flightTbl
          {
          border: 1.5px solid darkblue;

          }

        </style>
      </head>
      <body>
        <h2>
          Matching Flights:
          <xsl:value-of select="descendant::SourceAirport[1]"/>
          to
          <xsl:value-of select="descendant::DestAirport[1]"/>
        </h2>
        <table class="flightTbl" cellspacing="0"  >        
          <tr>
            <th>Flight number</th>
            <th>Date/Time</th>
            <th>Route</th>
            <th>Fare</th>
            <th>Seats</th>
          </tr>

          <xsl:apply-templates select="/ArrayOfFlight/Flight">
            <xsl:sort select="Fare" data-type="number"/>
           </xsl:apply-templates>
        </table>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="/ArrayOfFlight/Flight">
    <xsl:param name="string" select="DateAndTime" />
    <xsl:variable name="month" select="number(substring($string,6,2))"/>
    <xsl:variable name="day" select="number(substring($string,9,2))"/>
    <xsl:variable name="year" select="substring($string,1, 4)"/>
    <xsl:variable name="time" select="substring($string, 12,19)"/>
    <tr>
      <td>
        <xsl:value-of select="FlightNumber"/>
      </td>
      <td>
        <xsl:value-of select="$month"/>/<xsl:value-of select="$day"/>/<xsl:value-of select="$year"/>,
      <xsl:value-of select="$time"/>
        


      </td>
      <td>
        <xsl:value-of select="SourceAirport"/>
        to
        <xsl:value-of select="DestAirport"/>
      </td>
      <td>
        <xsl:value-of select="format-number(Fare,'#,###.00')"/>
      </td>
      <td>
        <xsl:value-of select="Seats"/>
      </td>
    </tr>
  </xsl:template>


</xsl:stylesheet>
