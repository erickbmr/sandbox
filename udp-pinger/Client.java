import java.io.*;
import java.net.*;
import java.util.*;

public class Client {
    public static void main(String[] args) throws Exception {
        InetAddress host = InetAddress.getByName(args[0]);
        int portNumber = Integer.parseInt(args[1]);

        DatagramSocket socket = new DatagramSocket();
        socket.setSoTimeout(1000);

        for (int i = 0; i < 10; i++) {
            long time = System.currentTimeMillis();
            
            String message = "ping " + i + " ";

            DatagramPacket sendPacket = new DatagramPacket(
                message.getBytes(),
                message.length(),
                host,
                portNumber
            );

            socket.send(sendPacket);
            System.out.println(message);

            DatagramPacket receivedPacket = new DatagramPacket(new byte[1024], 1024);

            try {
                socket.receive(receivedPacket);
                long receivedTime = System.currentTimeMillis();
                System.out.println("reponse received - address: " + receivedPacket.getAddress().getHostAddress() + " | time: " + (receivedTime - time) + "ms");
            } catch (SocketTimeoutException ex) {
                System.out.println("timeout - " + ex.getMessage());
                return;
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
                return;
            }
        }
    }
}