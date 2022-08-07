import { createContext } from "react";
import ActivityStore from "./activityStore";

interface Store {
    activityStore: ActivityStore
}

export const store: Store = {
    activityStore: new ActivityStore()
};

export const StoreContext = createContext(store);

XPathEvaluator 