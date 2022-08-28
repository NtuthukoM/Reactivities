import { createContext, useContext } from "react";
import ActivityStore from "./activityStore";
import CommonStore from "./commonStore";

interface Store {
    activityStore: ActivityStore,
    commonStore: CommonStore
}

export const store: Store = {
    activityStore: new ActivityStore();
    CommonStore
};

export const StoreContext = createContext(store);

export function useStore(){
    return useContext(StoreContext);
}