# Exposing IIS Express to the Network
If you want to use IIS Express and allow external access, you need to explicitly change the bindings in the solution applicationhost.config file which can be found in ```<solutionRoot>\.vs\config.```Change the bindingInformation to:

```
<site name="AlbumViewerNetCore" id="2">
    <application path="/" applicationPool="Clr4IntegratedAppPool">
      <virtualDirectory path="/" physicalPath="C:\projects2010\AlbumViewerVNext\src\AlbumViewerNetCore" />
    </application>
    <bindings>          
      <binding protocol="http" bindingInformation="*:26448:*" />
    </bindings>
</site>
```
changing the ```*:26448:localhost``` to ```*:26448:*``` where 26448 is the IIS Express port.

Then run:
```
netsh http add urlacl url=http://*:26448/ user=Interactive listen=yes
```
to bind the http.sys entry.

Finally open the firewall to allow inbound connections to the specific IIS Express port:
```
netsh advfirewall firewall add rule name="Http Port 26448" dir=in action=allow protocol=TCP localport=26448
```
and you should be off to the races.