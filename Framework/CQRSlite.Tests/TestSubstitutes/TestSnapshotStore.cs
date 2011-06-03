﻿using System;
using CQRSlite.Domain;
using CQRSlite.Eventing;

namespace CQRSlite.Tests.TestSubstitutes
{
    public class TestSnapshotStore : ISnapshotStore
    {
        public bool VerifyGet { get; private set; }
        public bool VerifySave { get; private set; }
        public int SavedVersion { get; private set; }

        public Snapshot Get(Guid id)
        {
            VerifyGet = true;
            return new TestSnapshotAggreagateSnapshot();
        }

        public void Save(Snapshot snapshot)
        {
            VerifySave = true;
            SavedVersion = snapshot.Version;
        }
    }
}
