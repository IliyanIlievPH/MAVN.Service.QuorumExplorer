﻿// <auto-generated />
using MAVN.Service.QuorumExplorer.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MAVN.Service.QuorumExplorer.MsSqlRepositories.Migrations
{
    [DbContext(typeof(QeContext))]
    [Migration("20200630112041_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("quorum_explorer")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.ABIEntity", b =>
                {
                    b.Property<string>("Signature")
                        .HasColumnName("signature")
                        .HasColumnType("text");

                    b.Property<string>("Abi")
                        .IsRequired()
                        .HasColumnName("abi")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnName("type")
                        .HasColumnType("integer");

                    b.HasKey("Signature");

                    b.HasIndex("Name");

                    b.HasIndex("Type");

                    b.ToTable("ABIs");
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.BlocksDataEntity", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnName("key")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("value")
                        .HasColumnType("text");

                    b.HasKey("Key");

                    b.ToTable("blocks_data");
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.EventEntity", b =>
                {
                    b.Property<long>("LogIndex")
                        .HasColumnName("log_index")
                        .HasColumnType("bigint");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash")
                        .HasColumnType("text");

                    b.Property<long>("BlockTimestamp")
                        .HasColumnName("block_timestamp")
                        .HasColumnType("bigint");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnName("event_name")
                        .HasColumnType("text");

                    b.Property<string>("EventSignature")
                        .IsRequired()
                        .HasColumnName("event_signature")
                        .HasColumnType("text");

                    b.Property<string>("ParametersJson")
                        .IsRequired()
                        .HasColumnName("parameters_json")
                        .HasColumnType("text");

                    b.HasKey("LogIndex", "TransactionHash");

                    b.HasIndex("BlockTimestamp");

                    b.HasIndex("EventName");

                    b.HasIndex("EventSignature");

                    b.HasIndex("TransactionHash");

                    b.HasIndex("LogIndex", "TransactionHash");

                    b.HasIndex("BlockTimestamp", "LogIndex", "TransactionHash");

                    b.HasIndex("BlockTimestamp", "LogIndex", "TransactionHash", "EventName");

                    b.ToTable("events");
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.EventParameterEntity", b =>
                {
                    b.Property<long>("LogIndex")
                        .HasColumnName("log_index")
                        .HasColumnType("bigint");

                    b.Property<int>("ParameterOrder")
                        .HasColumnName("parameter_order")
                        .HasColumnType("integer");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash")
                        .HasColumnType("text");

                    b.Property<string>("ParameterName")
                        .IsRequired()
                        .HasColumnName("parameter_name")
                        .HasColumnType("text");

                    b.Property<string>("ParameterType")
                        .IsRequired()
                        .HasColumnName("parameter_type")
                        .HasColumnType("text");

                    b.Property<string>("ParameterValue")
                        .IsRequired()
                        .HasColumnName("parameter_value")
                        .HasColumnType("text");

                    b.Property<string>("ParameterValueHash")
                        .IsRequired()
                        .HasColumnName("parameter_value_hash")
                        .HasColumnType("text");

                    b.HasKey("LogIndex", "ParameterOrder", "TransactionHash");

                    b.HasIndex("TransactionHash");

                    b.HasIndex("LogIndex", "TransactionHash");

                    b.HasIndex("ParameterType", "ParameterValueHash");

                    b.ToTable("event_parameters");
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.FunctionCallEntity", b =>
                {
                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash")
                        .HasColumnType("text");

                    b.Property<string>("FunctionName")
                        .IsRequired()
                        .HasColumnName("function_name")
                        .HasColumnType("text");

                    b.Property<string>("FunctionSignature")
                        .IsRequired()
                        .HasColumnName("function_signature")
                        .HasColumnType("text");

                    b.Property<string>("ParametersJson")
                        .IsRequired()
                        .HasColumnName("parameters_json")
                        .HasColumnType("text");

                    b.HasKey("TransactionHash");

                    b.HasIndex("TransactionHash");

                    b.ToTable("function_calls");
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.FunctionCallParameterEntity", b =>
                {
                    b.Property<int>("ParameterOrder")
                        .HasColumnName("parameter_order")
                        .HasColumnType("integer");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash")
                        .HasColumnType("text");

                    b.Property<string>("FunctionCallTransactionHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ParameterName")
                        .IsRequired()
                        .HasColumnName("parameter_name")
                        .HasColumnType("text");

                    b.Property<string>("ParameterType")
                        .IsRequired()
                        .HasColumnName("parameter_type")
                        .HasColumnType("text");

                    b.Property<string>("ParameterValue")
                        .IsRequired()
                        .HasColumnName("parameter_value")
                        .HasColumnType("text");

                    b.Property<string>("ParameterValueHash")
                        .IsRequired()
                        .HasColumnName("parameter_value_hash")
                        .HasColumnType("text");

                    b.HasKey("ParameterOrder", "TransactionHash");

                    b.HasIndex("FunctionCallTransactionHash");

                    b.HasIndex("ParameterType", "ParameterValueHash");

                    b.ToTable("function_call_parameters");
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.TransactionEntity", b =>
                {
                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash")
                        .HasColumnType("text");

                    b.Property<string>("BlockHash")
                        .IsRequired()
                        .HasColumnName("block_hash")
                        .HasColumnType("text");

                    b.Property<long>("BlockNumber")
                        .HasColumnName("block_number")
                        .HasColumnType("bigint");

                    b.Property<long>("BlockTimestamp")
                        .HasColumnName("block_timestamp")
                        .HasColumnType("bigint");

                    b.Property<string>("ContractAddress")
                        .HasColumnName("contract_address")
                        .HasColumnType("text");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnName("from")
                        .HasColumnType("text");

                    b.Property<string>("Input")
                        .HasColumnName("input")
                        .HasColumnType("text");

                    b.Property<string>("InputSignature")
                        .HasColumnName("input_signature")
                        .HasColumnType("text");

                    b.Property<long>("Nonce")
                        .HasColumnName("nonce")
                        .HasColumnType("bigint");

                    b.Property<long>("Status")
                        .HasColumnName("status")
                        .HasColumnType("bigint");

                    b.Property<string>("To")
                        .HasColumnName("to")
                        .HasColumnType("text");

                    b.Property<long>("TransactionIndex")
                        .HasColumnName("transaction_index")
                        .HasColumnType("bigint");

                    b.HasKey("TransactionHash");

                    b.HasIndex("BlockHash");

                    b.HasIndex("BlockNumber");

                    b.HasIndex("BlockTimestamp");

                    b.HasIndex("ContractAddress");

                    b.HasIndex("From");

                    b.HasIndex("Status");

                    b.HasIndex("To");

                    b.HasIndex("BlockHash", "TransactionIndex")
                        .IsUnique();

                    b.HasIndex("From", "Nonce")
                        .IsUnique();

                    b.ToTable("transactions");
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.TransactionLogEntity", b =>
                {
                    b.Property<long>("LogIndex")
                        .HasColumnName("log_index")
                        .HasColumnType("bigint");

                    b.Property<string>("TransactionHash")
                        .HasColumnName("transaction_hash")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("address")
                        .HasColumnType("text");

                    b.Property<long>("BlockTimestamp")
                        .HasColumnName("block_timestamp")
                        .HasColumnType("bigint");

                    b.Property<string>("Data")
                        .HasColumnName("data")
                        .HasColumnType("text");

                    b.Property<bool>("Decoded")
                        .HasColumnName("decoded")
                        .HasColumnType("boolean");

                    b.Property<string>("Topic0")
                        .IsRequired()
                        .HasColumnName("topic_0")
                        .HasColumnType("text");

                    b.Property<string>("Topic1")
                        .HasColumnName("topic_1")
                        .HasColumnType("text");

                    b.Property<string>("Topic2")
                        .HasColumnName("topic_2")
                        .HasColumnType("text");

                    b.Property<string>("Topic3")
                        .HasColumnName("topic_3")
                        .HasColumnType("text");

                    b.HasKey("LogIndex", "TransactionHash");

                    b.HasIndex("Address");

                    b.HasIndex("BlockTimestamp");

                    b.HasIndex("Decoded");

                    b.HasIndex("Topic0");

                    b.HasIndex("Topic1");

                    b.HasIndex("Topic2");

                    b.HasIndex("Topic3");

                    b.HasIndex("TransactionHash");

                    b.ToTable("transaction_logs");
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.EventEntity", b =>
                {
                    b.HasOne("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.TransactionLogEntity", "TransactionLog")
                        .WithOne("Event")
                        .HasForeignKey("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.EventEntity", "LogIndex", "TransactionHash")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.EventParameterEntity", b =>
                {
                    b.HasOne("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.EventEntity", "Event")
                        .WithMany("Parameters")
                        .HasForeignKey("LogIndex", "TransactionHash")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.FunctionCallEntity", b =>
                {
                    b.HasOne("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.TransactionEntity", "Transaction")
                        .WithOne("FunctionCall")
                        .HasForeignKey("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.FunctionCallEntity", "TransactionHash")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.FunctionCallParameterEntity", b =>
                {
                    b.HasOne("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.FunctionCallEntity", "FunctionCall")
                        .WithMany("Parameters")
                        .HasForeignKey("FunctionCallTransactionHash")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.TransactionLogEntity", b =>
                {
                    b.HasOne("MAVN.Service.QuorumExplorer.MsSqlRepositories.Entities.TransactionEntity", "Transaction")
                        .WithMany("Logs")
                        .HasForeignKey("TransactionHash")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}