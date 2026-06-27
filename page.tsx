
import Layout from "@/components/Layout";
import DashboardHeader from "@/components/DashboardHeader";
import WatchlistTable from "@/components/WatchlistTable";

export default function WatchlistPage(){
 return(
  <Layout>
   <div className="p-8 space-y-8">
    <DashboardHeader/>
    <WatchlistTable/>
   </div>
  </Layout>
 );
}
