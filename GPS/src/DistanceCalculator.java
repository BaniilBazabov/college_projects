import java.io.File;
import java.util.Scanner;

public class DistanceCalculator {
    public static Double [][] array = new Double [121][3];
    public static int currentI =0;
    public static double currentX = 53.3842125238019;
    public static double currentY = -6.60088967821164;
    public static int currentClosestI;
    public static double currentClosestX;
    public static double currentClosestY;

    public static void main(String args[]) throws Exception{
        Double shortest =0.0;
        String sequence = "0,";
        String currentDir = System.getProperty("user.dir") + "\\src\\loc.txt";
        Scanner sc = new Scanner(new File(currentDir));

        for(int i=0;i<122;i++){
            for(int j=0;j<3;j++){
                if(sc.hasNext()) array[i][j]=Double.parseDouble(sc.next());
            }
        }

        double zeroX = array[0][1];
        double zeroY = array[0][2];
        array[0][0]=null;
        array[0][1]=null;
        array[0][2]=null;
        for(int i=0;i<120;i++){
            shortest = shortest +compareAll(currentX,currentY);
            sequence = sequence + currentClosestI+',';
            currentX = currentClosestX;
            currentY = currentClosestY;
        }
        shortest = shortest + CalcDistance(currentX,currentY,zeroX,zeroY);
        System.out.println(shortest);
        System.out.println(sequence + '0');


       /* ArrayList<Double> results = new ArrayList<>();
        ArrayList<Double> finalResults = new ArrayList<>();

         for(int i = 0; i<38;i++){
            for(int j=0;j<38;j++){
                if(j==i) j++;
                results.add(CalcDistance(array[i][0],array[i][1],array[j][0],array[j][1]));
                if(CalcDistance(array[i][0],array[i][1],array[j][0],array[j][1])==7.193861673500173){
                    System.out.println((array[i][0]));
                    System.out.println((array[i][1]));
                }

            }
            results.sort(Comparator.naturalOrder());
            finalResults.add(results.get(9));
            results.clear();
        }
        finalResults.sort(Comprator.naturalOrder());
        System.out.println(finalResults.get(0));  //Adamstown Community College / Castleknock community College
*/
    }
    public static double compareAll(double x, double y){
        double minimum = Integer.MAX_VALUE;
        for(int i=0;i<121;i++){
            if(array[i][1]==null) continue;
            else if(CalcDistance(x,y,array[i][1],array[i][2])<minimum && x!=array[i][1] && y!=array[i][2] && array[i][0] !=null){
                minimum = CalcDistance(x,y,array[i][1],array[i][2]);
                currentClosestI = i;
                currentClosestX = array[i][1];
                currentClosestY = array[i][2];
            }
        }
        array[currentClosestI][0]=null;
        array[currentClosestI][1]=null;
        array[currentClosestI][2]=null;
        return minimum;
    }
    public static double CalcDistance(Double lat1,Double lon1, Double lat2, Double lon2){
        int Radius = 6371;
        Double Lat1 = lat1;
        Double Lon1 = lon1;
        Double Lat2 = lat2;
        Double Lon2 = lon2;
        Double latDistance = toRad(Lat2-Lat1);
        Double lonDistance = toRad(Lon2-Lon1);
        Double a = Math.sin(latDistance/2)*Math.sin(latDistance/2)+Math.cos(toRad(Lat1)) * Math.cos(toRad(Lat2)) * Math.sin(lonDistance/2) *Math.sin(lonDistance/2);
        Double c = 2*Math.atan2(Math.sqrt(a), Math.sqrt(1-a));
        Double distance = Radius*c;
        return distance;
    }
    public static Double toRad(Double value){
        return value*Math.PI/100;
    }
}
