import { createContext, useContext } from "react";
import ActivityStore from "./activityStore";

interface Store {
    activityStore: ActivityStore,
    commonStore: ComminSt
}

export const store: Store = {
    activityStore: new ActivityStore()
};

export const StoreContext = createContext(store);

export function useStore(){
    return useContext(StoreContext);
}