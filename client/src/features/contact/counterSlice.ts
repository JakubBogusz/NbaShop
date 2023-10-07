import { createSlice } from "@reduxjs/toolkit"

interface CounterState {
    title: string;
    data: number;
}

const initialState: CounterState = {
    title: '(Counter example with Redux Toolkit)',
    data: 42
}

export const counterSlice = createSlice({
    name: 'counter',
    initialState,
    reducers: {
        increment: (state, action) => {
            state.data += action.payload;
        },
        decrement: (state, action) => {
            state.data -= action.payload
        }
    }
})

export const {increment, decrement} = counterSlice.actions;