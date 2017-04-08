S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 10007
Date: 2017-04-07 02:19:17+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 10007, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xb769d068
r2   = 0x000003ff, r3   = 0x00000000
r4   = 0xb6f37114, r5   = 0xb6759470
r6   = 0x40000046, r7   = 0x00000123
r8   = 0x8009e6f6, r9   = 0xb6e5beac
r10  = 0xb27f34bd, fp   = 0xbef2beac
ip   = 0x00000000, sp   = 0xbef2be80
lr   = 0xb40c84c0, pc   = 0xb67594b4
cpsr = 0x800f0010

Memory Information
MemTotal:   987012 KB
MemFree:    156044 KB
Buffers:     50260 KB
Cached:     325500 KB
VmPeak:     152232 KB
VmSize:     134404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       39652 KB
VmRSS:       34264 KB
VmData:      51492 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10007 TID = 10007
10007 10008 10168 10169 10177 

Maps Information
af1ec000 af9eb000 rw-p [stack:10177]
b0f6d000 b0f7e000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f8e000 b0f93000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1395000 b139d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13af000 b1bae000 rw-p [stack:10169]
b1bae000 b1baf000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bbf000 b1bd3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1be7000 b1be8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf8000 b1bfb000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c0c000 b1c0d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c1d000 b1c1f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c2f000 b1c31000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c41000 b1c51000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c61000 b1c6d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c7f000 b247e000 rw-p [stack:10168]
b27af000 b27b6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c9000 b27cf000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27df000 b27fb000 r-xp /opt/usr/apps/org.example.client/bin/client
b2954000 b2a37000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a6e000 b2a96000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aa8000 b32a7000 rw-p [stack:10008]
b32a7000 b32a9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32b9000 b32c3000 r-xp /lib/libnss_files-2.20-2014.11.so
b32d4000 b32dd000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32ee000 b32ff000 r-xp /lib/libnsl-2.20-2014.11.so
b3312000 b3318000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3329000 b332a000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3352000 b3359000 r-xp /usr/lib/libminizip.so.1.0.0
b3369000 b336e000 r-xp /usr/lib/libstorage.so.0.1
b337e000 b33dd000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33f3000 b3407000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3417000 b345b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b346b000 b3473000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3483000 b34b3000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34c6000 b357f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3593000 b35e6000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35f7000 b3612000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3622000 b36e3000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36f6000 b3706000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3716000 b3723000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3734000 b373b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b374b000 b378c000 r-xp /usr/lib/libmdm.so.1.2.12
b379c000 b37a4000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37b3000 b37c3000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37e4000 b3844000 r-xp /usr/lib/libasound.so.2.0.0
b3856000 b3859000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3869000 b386c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b387c000 b3881000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3891000 b3892000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38a2000 b38ad000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38c1000 b38c8000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38d8000 b38de000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38ee000 b38f3000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3903000 b391e000 r-xp /usr/lib/libmmfsound.so.0.1.0
b392e000 b3935000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3945000 b3948000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3959000 b3987000 r-xp /usr/lib/libidn.so.11.5.44
b3997000 b39ad000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39be000 b39c8000 r-xp /usr/lib/libcares.so.2.1.0
b39d8000 b39e2000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39f2000 b39f4000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a04000 b3a05000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a15000 b3a19000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a2a000 b3a52000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a63000 b3a8c000 r-xp /usr/lib/libturbojpeg.so
b3aac000 b3ab2000 r-xp /usr/lib/libgif.so.4.1.6
b3ac2000 b3b08000 r-xp /usr/lib/libcurl.so.4.3.0
b3b19000 b3b3a000 r-xp /usr/lib/libexif.so.12.3.3
b3b55000 b3b6a000 r-xp /usr/lib/libtts.so
b3b7b000 b3b83000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b93000 b3c59000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c79000 b3d71000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d90000 b3e5e000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e75000 b3e77000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e87000 b3e8d000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e9d000 b3ec0000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ed1000 b3ed3000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ee3000 b3ee5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ef6000 b3efb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f12000 b3f14000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f24000 b3f2b000 r-xp /usr/lib/libsensord-share.so
b3f3b000 b3f53000 r-xp /usr/lib/libsensor.so.1.1.0
b3f64000 b3f67000 r-xp /usr/lib/libXv.so.1.0.0
b3f77000 b3f7c000 r-xp /usr/lib/libutilX.so.1.1.0
b3f8c000 b3f91000 r-xp /usr/lib/libappcore-common.so.1.1
b3fa1000 b3fa8000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fbb000 b3fbf000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fd0000 b40ae000 r-xp /usr/lib/libCOREGL.so.4.0
b40ce000 b40d1000 r-xp /usr/lib/libuuid.so.1.3.0
b40e1000 b40f8000 r-xp /usr/lib/libblkid.so.1.1.0
b4109000 b410b000 r-xp /usr/lib/libXau.so.6.0.0
b411b000 b4162000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4174000 b417a000 r-xp /usr/lib/libjson-c.so.2.0.1
b418b000 b418f000 r-xp /usr/lib/libogg.so.0.7.1
b419f000 b41c1000 r-xp /usr/lib/libvorbis.so.0.4.3
b41d1000 b42b5000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42d1000 b42d4000 r-xp /usr/lib/libEGL.so.1.4
b42e5000 b42eb000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42fb000 b42fd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b430d000 b431a000 r-xp /usr/lib/libGLESv2.so.2.0
b432b000 b438d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43a2000 b43ba000 r-xp /usr/lib/libmount.so.1.1.0
b43cc000 b43e0000 r-xp /usr/lib/libxcb.so.1.1.0
b43f0000 b43f7000 r-xp /lib/libcrypt-2.20-2014.11.so
b442f000 b4431000 r-xp /usr/lib/libiri.so
b4441000 b444c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b445d000 b4493000 r-xp /usr/lib/libpulse.so.0.16.2
b44a4000 b44e7000 r-xp /usr/lib/libsndfile.so.1.0.25
b44fc000 b4511000 r-xp /lib/libexpat.so.1.5.2
b4523000 b45e1000 r-xp /usr/lib/libcairo.so.2.11200.14
b45f5000 b45fd000 r-xp /usr/lib/libdrm.so.2.4.0
b460d000 b4610000 r-xp /usr/lib/libdri2.so.0.0.0
b4620000 b466e000 r-xp /usr/lib/libssl.so.1.0.0
b4683000 b468f000 r-xp /usr/lib/libeeze.so.1.13.0
b46a0000 b46a9000 r-xp /usr/lib/libethumb.so.1.13.0
b46b9000 b46bc000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46cc000 b4883000 r-xp /usr/lib/libcrypto.so.1.0.0
b566e000 b5677000 r-xp /usr/lib/libXi.so.6.1.0
b5687000 b5689000 r-xp /usr/lib/libXgesture.so.7.0.0
b5699000 b569d000 r-xp /usr/lib/libXtst.so.6.1.0
b56ad000 b56b3000 r-xp /usr/lib/libXrender.so.1.3.0
b56c3000 b56c9000 r-xp /usr/lib/libXrandr.so.2.2.0
b56d9000 b56db000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ec000 b56ef000 r-xp /usr/lib/libXfixes.so.3.1.0
b56ff000 b570a000 r-xp /usr/lib/libXext.so.6.4.0
b571a000 b571c000 r-xp /usr/lib/libXdamage.so.1.1.0
b572c000 b572e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b573e000 b5820000 r-xp /usr/lib/libX11.so.6.3.0
b5834000 b583b000 r-xp /usr/lib/libXcursor.so.1.0.2
b584b000 b5863000 r-xp /usr/lib/libudev.so.1.6.0
b5865000 b5868000 r-xp /lib/libattr.so.1.1.0
b5878000 b5898000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5899000 b589e000 r-xp /usr/lib/libffi.so.6.0.2
b58af000 b58c7000 r-xp /lib/libz.so.1.2.8
b58d7000 b58d9000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58e9000 b59be000 r-xp /usr/lib/libxml2.so.2.9.2
b59d3000 b5a6e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a8a000 b5a8d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a9d000 b5ab6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ac7000 b5ad8000 r-xp /lib/libresolv-2.20-2014.11.so
b5aec000 b5b66000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b7b000 b5b7d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b8d000 b5b94000 r-xp /usr/lib/libembryo.so.1.13.0
b5ba4000 b5bae000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bbf000 b5bd7000 r-xp /usr/lib/libpng12.so.0.50.0
b5be8000 b5c0b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c2c000 b5c40000 r-xp /usr/lib/libector.so.1.13.0
b5c51000 b5c69000 r-xp /usr/lib/liblua-5.1.so
b5c7a000 b5cd1000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ce5000 b5d0d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d1e000 b5d31000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d42000 b5d7c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d8d000 b5d9b000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dab000 b5db3000 r-xp /usr/lib/libtbm.so.1.0.0
b5dc3000 b5dd0000 r-xp /usr/lib/libeio.so.1.13.0
b5de0000 b5de2000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5df2000 b5df7000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e07000 b5e1e000 r-xp /usr/lib/libefreet.so.1.13.0
b5e30000 b5e50000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e60000 b5e80000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e82000 b5e88000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e98000 b5ea9000 r-xp /usr/lib/libemotion.so.1.13.0
b5eba000 b5ec1000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ed1000 b5ee0000 r-xp /usr/lib/libeo.so.1.13.0
b5ef1000 b5f03000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f14000 b5f19000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f29000 b5f42000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f52000 b5f6f000 r-xp /usr/lib/libeet.so.1.13.0
b5f88000 b5fd0000 r-xp /usr/lib/libeina.so.1.13.0
b5fe1000 b5ff1000 r-xp /usr/lib/libefl.so.1.13.0
b6002000 b60e7000 r-xp /usr/lib/libicuuc.so.51.1
b6104000 b6244000 r-xp /usr/lib/libicui18n.so.51.1
b625b000 b6293000 r-xp /usr/lib/libecore_x.so.1.13.0
b62a5000 b62a8000 r-xp /lib/libcap.so.2.21
b62b8000 b62e1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62f2000 b62f9000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b630b000 b6342000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6353000 b643e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6451000 b64ca000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64dc000 b64e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64f1000 b64fb000 r-xp /usr/lib/libvconf.so.0.2.45
b650b000 b650d000 r-xp /usr/lib/libvasum.so.0.3.1
b651d000 b651f000 r-xp /usr/lib/libttrace.so.1.1
b652f000 b6532000 r-xp /usr/lib/libiniparser.so.0
b6542000 b6568000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6578000 b657d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b658e000 b65a5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65b6000 b6621000 r-xp /lib/libm-2.20-2014.11.so
b6632000 b6638000 r-xp /lib/librt-2.20-2014.11.so
b6649000 b6656000 r-xp /usr/lib/libunwind.so.8.0.1
b668c000 b67b0000 r-xp /lib/libc-2.20-2014.11.so
b67c5000 b67de000 r-xp /lib/libgcc_s-4.9.so.1
b67ee000 b68d0000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68e1000 b690b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b691c000 b6958000 r-xp /usr/lib/libsystemd.so.0.4.0
b695a000 b69dd000 r-xp /usr/lib/libedje.so.1.13.0
b69f0000 b6a0e000 r-xp /usr/lib/libecore.so.1.13.0
b6a2e000 b6bb5000 r-xp /usr/lib/libevas.so.1.13.0
b6bea000 b6bfe000 r-xp /lib/libpthread-2.20-2014.11.so
b6c12000 b6e46000 r-xp /usr/lib/libelementary.so.1.13.0
b6e75000 b6e79000 r-xp /usr/lib/libsmack.so.1.0.0
b6e89000 b6e90000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea0000 b6ea2000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb2000 b6eb5000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec5000 b6ec7000 r-xp /lib/libdl-2.20-2014.11.so
b6ed8000 b6ef0000 r-xp /usr/lib/libaul.so.0.1.0
b6f04000 b6f09000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f1a000 b6f27000 r-xp /usr/lib/liblptcp.so
b6f39000 b6f3d000 r-xp /usr/lib/libsys-assert.so
b6f4e000 b6f6e000 r-xp /lib/ld-2.20-2014.11.so
b6f7f000 b6f84000 r-xp /usr/bin/launchpad-loader
b7442000 b7dc4000 rw-p [heap]
bef0c000 bef2d000 rw-p [stack]
bef0c000 bef2d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10007)
Call Stack Count: 4
 0: recv + 0x44 (0xb67594b4) [/lib/libc.so.6] + 0xcd4b4
 1: recv + 0xfc (0xb6f1dd50) [/usr/lib/liblptcp.so] + 0x3d50
 2: _ZN9AppSocket11receiveDataEv + 0x5a (0xb27ef6e7) [/opt/usr/apps/org.example.client/bin/client] + 0x106e7
 3: (0x3ff) (null)
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
rrno -2, errmsg No such file or directory
04-07 01:47:52.003+0900 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-07 01:47:52.003+0900 E/RESOURCED(  665): freezer-process.c: freezer_process_pid_set(146) > Cant find process info for 562
04-07 01:47:52.013+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(2034795246) zone(/)
04-07 01:47:52.013+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 01:47:52.013+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 6-4-2017, 17:15:34 (UTC).
04-07 01:47:52.013+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 01:47:52.013+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_handler_idle(1780) > Unlock the display from LCD OFF
04-07 01:47:52.013+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __display_unlock_state(2278) > Unlock LCD OFF is successfully done
04-07 01:47:52.023+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-07 01:47:52.023+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/562/status successfully
04-07 01:47:52.023+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-07 01:47:52.023+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 01:47:52.033+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-07 01:47:52.043+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-07 01:47:52.043+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 01:47:52.053+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-07 01:47:52.063+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-07 01:47:52.063+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 38
04-07 01:47:52.063+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/sbin/connmand
04-07 01:47:52.063+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1491499072, Fri Apr  7 02:17:52 2017
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1321970021, next duetime: 1491499072
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1321970021)
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1491498934), due_time(1491499072)
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 6-4-2017, 17:15:34 (UTC).
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-07 01:47:52.063+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/562/status successfully
04-07 01:47:52.063+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1321970021) zone(/)
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 6-4-2017, 17:15:34 (UTC).
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 01:47:52.063+0900 E/ALARM_MANAGER(  657): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[1321970021] is removed.
04-07 01:47:52.073+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-07 01:47:52.073+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/562/status successfully
04-07 01:47:52.073+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 0
04-07 01:47:52.073+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 01:47:52.083+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-07 01:47:52.093+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-07 01:47:52.093+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 01:47:52.104+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-07 01:47:52.114+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
04-07 01:47:52.114+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 38
04-07 01:47:52.114+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/sbin/connmand
04-07 01:47:52.114+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
04-07 01:47:52.114+0900 E/ALARM_MANAGER(  657): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1491500872, Fri Apr  7 02:47:52 2017
04-07 01:47:52.114+0900 E/ALARM_MANAGER(  657): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1321970021, next duetime: 1491500872
04-07 01:47:52.114+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1321970021)
04-07 01:47:52.114+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1491498934), due_time(1491500872)
04-07 01:47:52.114+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 01:47:52.114+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 6-4-2017, 17:15:34 (UTC).
04-07 01:47:52.114+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 02:15:33.995+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_handler_idle(1754) > Lock the display not to enter LCD OFF
04-07 02:15:33.995+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __display_lock_state(2235) > Lock LCD OFF is successfully done
04-07 02:15:33.995+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_expired(1526) > zone: /
04-07 02:15:34.005+0900 W/AUL     (  657): app_signal.c: aul_update_freezer_status(354) > send_update_freezer_status, pid: 1043, type: wakeup
04-07 02:15:34.005+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-07 02:15:34.005+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-07 02:15:34.005+0900 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-07 02:15:34.005+0900 E/RESOURCED(  665): freezer-process.c: freezer_process_pid_set(146) > Cant find process info for 1043
04-07 02:15:34.005+0900 E/ALARM_MANAGER( 1043): alarm-lib.c: __handle_expiry_method_call(170) > [alarm-lib] Alarm expired for [ALARM.apush] : Alarm id [1367490432]
04-07 02:15:34.005+0900 E/ALARM_MANAGER( 1043): alarm-lib.c: __handle_expiry_method_call(178) > [alarm-lib] Call expired callback
04-07 02:15:34.025+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1367490432) zone(/)
04-07 02:15:34.025+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 02:15:34.025+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 6-4-2017, 17:47:52 (UTC).
04-07 02:15:34.025+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 02:15:34.025+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_handler_idle(1780) > Unlock the display from LCD OFF
04-07 02:15:34.035+0900 I/AUL     ( 1043): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:34.035+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __display_unlock_state(2278) > Unlock LCD OFF is successfully done
04-07 02:15:34.045+0900 I/AUL     ( 1043): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:34.045+0900 E/ALARM_MANAGER( 1043): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(15), start(7-4-2017, 02:15:49), repeat(0), interval(0), type(-1073741822)
04-07 02:15:34.055+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-07 02:15:34.055+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1043/status successfully
04-07 02:15:34.055+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
04-07 02:15:34.055+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:15:34.065+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:34.075+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:34.075+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:15:34.085+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:34.095+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:34.095+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 38
04-07 02:15:34.095+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
04-07 02:15:34.095+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
04-07 02:15:34.095+0900 E/ALARM_MANAGER(  657): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1491498949, Fri Apr  7 02:15:49 2017
04-07 02:15:34.095+0900 E/ALARM_MANAGER(  657): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1584929068, next duetime: 1491498949
04-07 02:15:34.095+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1584929068)
04-07 02:15:34.095+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1491500872), due_time(1491498949)
04-07 02:15:34.095+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 02:15:34.095+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 6-4-2017, 17:15:49 (UTC).
04-07 02:15:34.095+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 02:15:39.170+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-07 02:15:39.170+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1043/status successfully
04-07 02:15:39.170+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
04-07 02:15:39.170+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_remove_from_list(639) > [alarm-server]:Remove alarm id(1584929068) zone(/)
04-07 02:15:39.170+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 02:15:39.170+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 6-4-2017, 17:47:52 (UTC).
04-07 02:15:39.170+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 02:15:39.170+0900 E/ALARM_MANAGER(  657): alarm-manager.c: alarm_manager_alarm_delete(2954) > alarm_id[1584929068] is removed.
04-07 02:15:39.170+0900 E/PUSHD   ( 1043): io.c: server_recv(270) > Fail to recv using curl
04-07 02:15:39.170+0900 E/PUSHD   ( 1043): proc.c: _receive_packet(2312) > ERROR : invalid return when receiving header [-1]
04-07 02:15:39.170+0900 W/PUSHD   ( 1043): ping.c: display_ping_status(380) > = PING_SUCCESS = avg[1200] inc[300] min[1200] max[2400] interval[2400] next_interval[2400] successes[33] max[1] mode[EXPLORE]
04-07 02:15:39.180+0900 I/AUL     ( 1043): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:39.190+0900 I/AUL     ( 1043): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:39.190+0900 E/ALARM_MANAGER( 1043): alarm-lib.c: alarmmgr_add_alarm_withcb(1281) > trigger_at_time(2400), start(7-4-2017, 02:55:39), repeat(0), interval(0), type(-1073741822)
04-07 02:15:39.190+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __get_zone_name(506) > zone name [/]
04-07 02:15:39.190+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2084) > Get proc/1043/status successfully
04-07 02:15:39.190+0900 W/ALARM_MANAGER(  657): alarm-manager.c: __check_privilege_by_cookie(2093) > uid : 200
04-07 02:15:39.190+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:15:39.200+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:39.210+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:39.210+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:15:39.220+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:39.230+0900 I/AUL_AMD (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/pushd, ret : 0
04-07 02:15:39.230+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 38
04-07 02:15:39.230+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/bin/pushd
04-07 02:15:39.230+0900 E/AUL_AMD (  610): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/bin/pushd
04-07 02:15:39.230+0900 E/ALARM_MANAGER(  657): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1491501339, Fri Apr  7 02:55:39 2017
04-07 02:15:39.230+0900 E/ALARM_MANAGER(  657): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1151894029, next duetime: 1491501339
04-07 02:15:39.230+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1151894029)
04-07 02:15:39.230+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1491500872), due_time(1491501339)
04-07 02:15:39.230+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 02:15:39.230+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 6-4-2017, 17:47:52 (UTC).
04-07 02:15:39.230+0900 E/ALARM_MANAGER(  657): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 02:19:04.090+0900 W/LOCKSCREEN(  853): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
04-07 02:19:04.090+0900 W/LOCKSCREEN(  853): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
04-07 02:19:04.090+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
04-07 02:19:04.090+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
04-07 02:19:04.090+0900 W/LOCKSCREEN(  853): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
04-07 02:19:04.090+0900 W/LOCKSCREEN(  853): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
04-07 02:19:04.100+0900 E/LOCKSCREEN(  853): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-07 02:19:04.100+0900 E/LOCKSCREEN(  853): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
04-07 02:19:04.100+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(195) > ""
04-07 02:19:04.110+0900 E/UXT     (  663): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 2:19
04-07 02:19:04.110+0900 I/INDICATOR(  663): clock.c: getTimeFormatted(176) > "time format : 오전 2:19"
04-07 02:19:04.110+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 2:19"
04-07 02:19:04.110+0900 W/INDICATOR(  663): clock.c: indicator_clock_changed_cb(272) > 
04-07 02:19:04.110+0900 I/INDICATOR(  663): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146282385 Time: <font_size=31> </font_size> <font_size=31> 오전 2:19</font_size></font>"
04-07 02:19:04.110+0900 I/INDICATOR(  663): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
04-07 02:19:04.110+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-07 02:19:04.110+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 02:19:04.110+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 02:19:04.110+0900 E/INDICATOR(  663): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-07 02:19:04.120+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 02:19:04.120+0900 E/INDICATOR(  663): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-07 02:19:04.330+0900 W/LOCKSCREEN(  853): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
04-07 02:19:04.330+0900 W/LOCKSCREEN(  853): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
04-07 02:19:04.330+0900 W/APP_CORE(  853): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
04-07 02:19:04.330+0900 I/APP_CORE(  853): appcore-efl.c: __do_app(514) > [APP 853] Event: RESUME State: PAUSED
04-07 02:19:04.330+0900 I/CAPI_APPFW_APPLICATION(  853): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-07 02:19:04.330+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
04-07 02:19:04.330+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
04-07 02:19:04.330+0900 W/LOCKSCREEN(  853): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-07 02:19:04.330+0900 W/AUL     (  853): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
04-07 02:19:04.340+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-07 02:19:04.340+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 853
04-07 02:19:04.340+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
04-07 02:19:04.350+0900 E/RESOURCED(  665): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-07 02:19:04.350+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 10513
04-07 02:19:04.400+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 10513
04-07 02:19:04.400+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 10513, appid: com.samsung.weather-m-agent
04-07 02:19:04.420+0900 W/AUL     (  853): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10513)
04-07 02:19:04.440+0900 I/Tizen::App( 1248): (499) > LaunchedApp(com.samsung.weather-m-agent)
04-07 02:19:04.440+0900 I/Tizen::App( 1248): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 10513.
04-07 02:19:04.590+0900 E/weather-agent(10513): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
04-07 02:19:04.590+0900 E/weather-common(10513): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
04-07 02:19:04.590+0900 E/weather-agent(10513): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
04-07 02:19:04.600+0900 I/MESSAGE_PORT(10513): message-port.c: __initialize(872) > initialize
04-07 02:19:04.610+0900 I/MESSAGE_PORT(10513): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
04-07 02:19:04.630+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-07 02:19:04.630+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-07 02:19:04.630+0900 I/MESSAGE_PORT(10513): message-port.c: __message_port_send_message(972) > port exist check !!
04-07 02:19:04.630+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
04-07 02:19:04.630+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
04-07 02:19:04.630+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-07 02:19:04.630+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-07 02:19:04.630+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
04-07 02:19:04.630+0900 I/MESSAGE_PORT(  853): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __message_port_send_message(972) > port exist check !!
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-07 02:19:04.640+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:19:04.640+0900 E/MESSAGE_PORT(10513): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __message_port_send_message(972) > port exist check !!
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __message_port_send_message(972) > port exist check !!
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-07 02:19:04.640+0900 I/MESSAGE_PORT( 1406): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-07 02:19:04.640+0900 E/MESSAGE_PORT(10513): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 흑석동[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Heukseok-dong[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 13.000000[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 15.900000[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 52.900000[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 4[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1491411158[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
04-07 02:19:04.640+0900 E/weather-common(10513): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : On[0;m
04-07 02:19:04.640+0900 E/weather-agent(10513): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
04-07 02:19:04.640+0900 E/weather-agent(10513): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-07 02:19:04.640+0900 I/MESSAGE_PORT(10513): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-07 02:19:04.650+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:19:04.670+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:19:04.710+0900 E/weather-widget( 1406): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
04-07 02:19:04.710+0900 E/weather-widget( 1406): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
04-07 02:19:04.710+0900 E/EFL     (  853): ecore_x<853> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=73901826
04-07 02:19:04.740+0900 I/Tizen::System( 1248): (280) > The screen has been turned on.
04-07 02:19:04.740+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-07 02:19:04.740+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-07 02:19:04.760+0900 W/LOCKSCREEN(  853): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
04-07 02:19:04.961+0900 E/EFL     (  853): ecore_x<853> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=73902070
04-07 02:19:04.961+0900 E/LOCKSCREEN(  853): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
04-07 02:19:04.961+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
04-07 02:19:04.961+0900 E/LOCKSCREEN(  853): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-07 02:19:04.971+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_create(409) > New handle created[0xb8c32240]
04-07 02:19:04.971+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_get_type(463) > Connected Network = 2
04-07 02:19:04.971+0900 I/CAPI_NETWORK_CONNECTION( 1406): connection.c: connection_destroy(427) > Destroy handle: 0xb8c32240
04-07 02:19:04.971+0900 E/weather-common( 1406): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-07 02:19:04.971+0900 W/LOCATION( 1406): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
04-07 02:19:04.971+0900 E/weather-common( 1406): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
04-07 02:19:05.001+0900 E/weather-widget( 1406): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
04-07 02:19:05.001+0900 I/CAPI_WIDGET_APPLICATION( 1406): widget_app.c: __provider_update_cb(287) > received updating signal
04-07 02:19:05.001+0900 E/EFL     ( 1406): edje<1406> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-07 02:19:05.031+0900 E/EFL     ( 1406): evas_main<1406> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80055350 is not stable during recalc loop
04-07 02:19:05.061+0900 E/EFL     ( 1406): evas_main<1406> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x80055350 is not stable during recalc loop
04-07 02:19:05.071+0900 E/EFL     ( 1406): edje<1406> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-07 02:19:05.091+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
04-07 02:19:05.091+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-07 02:19:05.291+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
04-07 02:19:05.291+0900 W/LOCKSCREEN(  853): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
04-07 02:19:05.291+0900 W/LOCKSCREEN(  853): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
04-07 02:19:05.291+0900 E/LOCKSCREEN(  853): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
04-07 02:19:05.291+0900 E/LOCKSCREEN(  853): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-07 02:19:05.301+0900 E/LOCKSCREEN(  853): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-07 02:19:05.301+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-07 02:19:05.301+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-07 02:19:05.301+0900 W/LOCKSCREEN(  853): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-07 02:19:05.301+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-07 02:19:05.301+0900 W/LOCKSCREEN(  853): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
04-07 02:19:05.301+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
04-07 02:19:05.301+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
04-07 02:19:05.311+0900 E/LOCKSCREEN(  853): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
04-07 02:19:05.311+0900 I/APP_CORE(  853): appcore-efl.c: __do_app(514) > [APP 853] Event: PAUSE State: RUNNING
04-07 02:19:05.311+0900 I/CAPI_APPFW_APPLICATION(  853): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-07 02:19:05.311+0900 E/LOCKSCREEN(  853): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-07 02:19:05.311+0900 E/LOCKSCREEN(  853): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-07 02:19:05.311+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
04-07 02:19:05.311+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
04-07 02:19:05.311+0900 W/LOCKSCREEN(  853): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-07 02:19:05.311+0900 E/LOCKSCREEN(  853): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-07 02:19:05.311+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-07 02:19:05.321+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(853) status(4)
04-07 02:19:05.321+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(853)
04-07 02:19:05.321+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 853, appid: com.samsung.lockscreen, status: bg
04-07 02:19:05.331+0900 I/APP_CORE(10007): appcore-efl.c: __do_app(514) > [APP 10007] Event: RESUME State: PAUSED
04-07 02:19:05.331+0900 I/CAPI_APPFW_APPLICATION(10007): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-07 02:19:05.341+0900 I/Tizen::System( 1248): (259) > Active app [org.exampl], current [com.samsun] 
04-07 02:19:05.341+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-07 02:19:05.341+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10007) status(3)
04-07 02:19:05.341+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-07 02:19:05.341+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-07 02:19:05.341+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(10007)
04-07 02:19:05.341+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10007, appid: org.example.client, status: fg
04-07 02:19:05.341+0900 I/APP_CORE(  853): appcore-efl.c: __do_app(514) > [APP 853] Event: MEM_FLUSH State: PAUSED
04-07 02:19:05.351+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-07 02:19:05.351+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:19:05.411+0900 W/LOCKSCREEN(  853): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
04-07 02:19:05.411+0900 E/LOCKSCREEN(  853): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-07 02:19:05.411+0900 E/LOCKSCREEN(  853): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-07 02:19:05.411+0900 W/LOCKSCREEN(  853): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-07 02:19:05.411+0900 W/LOCKSCREEN(  853): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-07 02:19:05.411+0900 E/LOCKSCREEN(  853): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
04-07 02:19:05.641+0900 E/weather-agent(10513): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
04-07 02:19:05.641+0900 I/CAPI_APPFW_APPLICATION(10513): service_app_main.c: service_app_exit(446) > service_app_exit
04-07 02:19:05.641+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-07 02:19:05.641+0900 E/weather-agent(10513): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
04-07 02:19:05.641+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-07 02:19:05.771+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-07 02:19:05.781+0900 I/Tizen::App( 1248): (243) > App[com.samsung.weather-m-agent] pid[10513] terminate event is forwarded
04-07 02:19:05.781+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-07 02:19:05.781+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 10513, ]
04-07 02:19:05.781+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-07 02:19:05.781+0900 I/Tizen::App( 1248): (506) > TerminatedApp(com.samsung.weather-m-agent)
04-07 02:19:05.781+0900 I/Tizen::App( 1248): (512) > Not registered pid(10513)
04-07 02:19:05.781+0900 I/Tizen::System( 1248): (246) > Terminated app [com.samsung.weather-m-agent]
04-07 02:19:05.781+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-07 02:19:05.781+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 10513
04-07 02:19:05.781+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10513
04-07 02:19:05.781+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-07 02:19:05.781+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 10513.
04-07 02:19:06.372+0900 E/EFL     (10007): ecore_x<10007> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=73903485
04-07 02:19:06.492+0900 E/EFL     (10007): ecore_x<10007> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=73903596
04-07 02:19:10.316+0900 I/APP_CORE(  853): appcore-efl.c: __do_app(514) > [APP 853] Event: MEM_FLUSH State: PAUSED
04-07 02:19:10.656+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-07 02:19:17.503+0900 E/RESOURCED(  665): proc-monitor.c: proc_dbus_watchdog_handler(711) > Receive watchdog signal to pid: 10007(client)
04-07 02:19:17.503+0900 E/RESOURCED(  665): proc-monitor.c: proc_dbus_watchdog_handler(727) > just kill watchdog process when debug enabled pid: 10007(client)
04-07 02:19:17.503+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > Fail to open file /sys/fs/cgroup/net_cls/(null)/cgroup.procs
04-07 02:19:17.503+0900 E/RESOURCED(  665): file-helper.c: fwrite_str(49) > errno -2, errmsg No such file or directory
04-07 02:19:17.503+0900 E/RESOURCED(  665): cgroup.c: place_pid_to_cgroup_by_fullpath(76) > Failed place all pid to cgroup /sys/fs/cgroup/net_cls/(null), error No such file or directory
04-07 02:19:17.633+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10007 pgid = 10007
04-07 02:19:17.633+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(143) > dead_pid(10007)
04-07 02:19:17.643+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-07 02:19:17.683+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(3)
04-07 02:19:17.683+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-07 02:19:17.683+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-07 02:19:17.683+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(869)
04-07 02:19:17.683+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 869, appid: com.samsung.homescreen, status: fg
04-07 02:19:17.683+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(869) status(0)
04-07 02:19:17.713+0900 I/APP_CORE(  869): appcore-efl.c: __do_app(514) > [APP 869] Event: RESUME State: PAUSED
04-07 02:19:17.713+0900 E/EFL     (  434): eo<434> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-07 02:19:17.713+0900 I/CAPI_APPFW_APPLICATION(  869): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-07 02:19:17.713+0900 E/cluster-home(  869): homescreen.cpp: OnResume(233) >  app resume
04-07 02:19:17.723+0900 I/AUL_PAD ( 1536): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-07 02:19:17.723+0900 I/AUL_PAD ( 1536): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-07 02:19:17.723+0900 E/AUL_PAD ( 1536): launchpad.c: main(698) > error reading sigchld info
04-07 02:19:17.723+0900 I/Tizen::App( 1248): (243) > App[org.example.client] pid[10007] terminate event is forwarded
04-07 02:19:17.723+0900 I/Tizen::System( 1248): (256) > osp.accessorymanager.service provider is found.
04-07 02:19:17.723+0900 I/Tizen::System( 1248): (196) > Accessory Owner is removed [org.example.client, 10007, ]
04-07 02:19:17.723+0900 I/Tizen::System( 1248): (256) > osp.system.service provider is found.
04-07 02:19:17.723+0900 I/Tizen::App( 1248): (506) > TerminatedApp(org.example.client)
04-07 02:19:17.723+0900 I/Tizen::App( 1248): (512) > Not registered pid(10007)
04-07 02:19:17.723+0900 I/Tizen::System( 1248): (246) > Terminated app [org.example.client]
04-07 02:19:17.723+0900 I/Tizen::Io( 1248): (729) > Entry not found
04-07 02:19:17.723+0900 I/ESD     (  901): esd_main.c: __esd_app_dead_handler(1773) > pid: 10007
04-07 02:19:17.723+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10007
04-07 02:19:17.723+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10007
04-07 02:19:17.753+0900 E/RESOURCED(  665): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.503
04-07 02:19:17.753+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-07 02:19:17.753+0900 I/CAPI_WIDGET_APPLICATION( 1436): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-07 02:19:17.753+0900 W/AUL     ( 1436): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1436, appid: live-com.samsung.browser, status: fg
04-07 02:19:17.763+0900 E/cluster-home(  869): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
04-07 02:19:17.763+0900 W/cluster-view(  869): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-07 02:19:17.773+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-07 02:19:17.773+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-07 02:19:17.773+0900 I/TIZEN_N_SOUND_MANAGER(  919): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-07 02:19:17.773+0900 E/TIZEN_N_SOUND_MANAGER(  919): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-07 02:19:17.773+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-07 02:19:17.823+0900 I/Tizen::System( 1248): (157) > change brightness system value.
04-07 02:19:17.823+0900 I/Tizen::App( 1248): (782) > Finished invoking application event listener for org.example.client, 10007.
04-07 02:19:17.833+0900 W/CRASH_MANAGER(10526): worker.c: worker_job(1199) > 0610007636c69149149915
