
# Among Us P2P

A helper utility to allow you to play [Among Us](https://innersloth.com/gameAmongUs.php) over a peer-to-peer connection on PC and iOS, eliminating the need to connect to the internet and Innersloth's matchmaking service. 

## How to Use

1. Download the [latest release](https://github.com/InvoxiPlayGames/AmongUsP2P/releases) or compile from source.
2. Launch the application, either on a PC you want to play on or a PC on the network of the device you want to play on.
3. Configure the application, either enabling "Ask for IP" or entering the IP of the host's game.
   - Enable "Broadcast to LAN" to discover the game on other devices on the network, such as iOS.
4. Open Among Us and navigate to the Local menu, then select either the IP you entered or "Join via IP", depending on whether "Ask for IP" is enabled.
5. Enjoy!

## How to Host

(Please note that the host of the game **does not need** to use the Among Us P2P application.)
1. Open Among Us and navigate to the Local menu, then click Start Game.
2. Ensure port 22023 is forwarded in your router to the device you are running Among Us on.
3. Give your IP address to the users you want to play with.

## TODO

- Test Android compatibility.
- Allow multiple games/devices to connect to one single Among Us P2P app.
- Improve stability.
- Add a utility to assist hosts (UPnP, port forwarding detection)
