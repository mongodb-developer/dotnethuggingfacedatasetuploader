# Hugging Face Dataset Uploader

The aim of this project is to provide a console application for inserting Hugging Face datasets into your MongoDB Cluster.

At the moment, it dowmnloads the [Embedded Movies dataset](https://huggingface.co/datasets/AIatMongoDB/embedded_movies) and uploads to a collection called embedded_movies insisde a sample_mflix database. If these don't exist, they will be created in your cluster automatically.

## Prerequisites
1. A MongoDB cluster deployed
2. Your connection string
3. DotNET SDK on your machine
4. This repo downloaded to your machine

## Running the uploader

1. From the root of the project on your machine, run ```dotnet run```.
2. Enter your connection string when requested

Once complete, you should see your data available inside your cluster.
