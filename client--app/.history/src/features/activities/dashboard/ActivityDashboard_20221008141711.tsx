import { observer } from "mobx-react-lite";
import React, { useEffect, useState } from "react";
import InfiniteScroll from "react-infinite-scroller";
import { Button, Grid } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { PagingParams } from "../../../app/models/pagination";
import { useStore } from "../../../app/stores/store";
import ActivityFilters from "./ActivityFilters";
import ActivityList from "./ActivityList";


export default observer(function ActivityDasbord(){
    const {activityStore} = useStore();
    const {loadActivities, activityRegistry, setPagingParams, pagination} = activityStore; 
    const [loadingNext, setLoadingNext] = useState(false);

    function handleGetNext(){
      setLoadingNext(true);
      setPagingParams(new PagingParams(pagination!.currentPage + 1));
      loadActivities().then(() => {
        setLoadingNext(false);
      });
    }

    useEffect(() => {
       if(activityRegistry.size <= 1) loadActivities()
      }, [activityRegistry, loadActivities]);    
      if(activityStore.loadingInitial && !loadingNext) return (
        <LoadingComponent content='Loading App'></LoadingComponent>
      )      
    return (
        <Grid>
            <Grid.Column width='10'>
              <InfiniteScroll
                pageStart={0}
                loadMore={handleGetNext}
                hasMore={!loadingNext && !!pagination && pagination.currentPage < pagination.totalPages}
                initialLoad={fail}
              >

              </InfiniteScroll>
            <ActivityList></ActivityList> 

            </Grid.Column>
            <Grid.Column width='6'>
               <ActivityFilters />
            </Grid.Column>

        </Grid>

    )
})