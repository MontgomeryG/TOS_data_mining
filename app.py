import streamlit as st
import pandas as pd
import numpy as np
import hvplot as hv
import plotly.express as px

st.write("# Think or Swim Data Mining Application")

st.write("11462 columns demonstration.")

# Bring in some sample output data.
# read in excel file

# THIS IS CURRENTLY AAPL TEST DATA
df = pd.read_excel("../TOS-data-mining/resources/TOS data 2024 01 16 00 10 02.xlsx")

# Save as .csv
df.to_csv('../TOS-data-mining/resources/TOS-test-data.csv', index=True)

# Fix index
df['Date']=pd.to_datetime(df['Date'])
df.set_index(df['Date'], inplace=True)
df = df.drop(columns=['Date'], axis=0)

# Show df
st.write("Raw Data")
st.write(df)

st.write("Summary Statistics")
# Summarize df
summary_stats = df.describe()
st.write(summary_stats)


st.write("Choosing arbitrary column to plot")
# Graph column
graph_data = df["AAPL Last"]
st.write(graph_data)

# st.write("Basic Line Chart")
# st.line_chart(graph_data)


st.write("Plot with plotly")
# Creating a line chart using plotly
fig = px.line(df, x=df.index, y=df['AAPL Last'])
st.plotly_chart(fig)

chart_list = []

for x in df.columns:
    fig = px.line(df, x=df.index, y=x)
    chart_list.append(fig)

first_plot = chart_list[1]
plot2 = chart_list[2]
plot3 = chart_list[3]
plot4 = chart_list[4]



st.plotly_chart(first_plot)
st.plotly_chart(plot2)
st.plotly_chart(plot3)
st.plotly_chart(plot4)

# Now allow users to plot any of the possible ones.
# plot them all, save the plots and choose 

# let's try to allow the users to pick a specific time?

