S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 19718
Date: 2017-06-02 20:27:15+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 19718, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004d06
r2   = 0x00000006, r3   = 0xb40b74c0
r4   = 0x00000002, r5   = 0xb40b7000
r6   = 0xb67b109c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5edf708
r10  = 0xb8dddfc0, fp   = 0x80087e42
ip   = 0x00000000, sp   = 0xbe956eb4
lr   = 0xb66a7f18, pc   = 0xb66a6b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     59964 KB
Buffers:     82648 KB
Cached:     276732 KB
VmPeak:     135324 KB
VmSize:     135148 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29448 KB
VmRSS:       29448 KB
VmData:      47240 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 19718 TID = 19718
19718 19719 20350 20351 20363 

Maps Information
aee8e000 af68d000 rw-p [stack:20363]
b1371000 b1379000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b138b000 b1b8a000 rw-p [stack:20351]
b1b8a000 b1b8b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b9b000 b1baf000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bc3000 b1bc4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bd4000 b1bd7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1be8000 b1be9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bf9000 b1bfb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c0b000 b1c0d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c1d000 b1c2d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c3d000 b1c49000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c5b000 b245a000 rw-p [stack:20350]
b278b000 b2792000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27a5000 b27ab000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27bb000 b27eb000 r-xp /opt/usr/apps/org.example.client/bin/client
b2943000 b2a26000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a5d000 b2a85000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a97000 b3296000 rw-p [stack:19719]
b3296000 b3298000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32a8000 b32b2000 r-xp /lib/libnss_files-2.20-2014.11.so
b32c3000 b32cc000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32dd000 b32ee000 r-xp /lib/libnsl-2.20-2014.11.so
b3301000 b3307000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3318000 b3319000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3341000 b3348000 r-xp /usr/lib/libminizip.so.1.0.0
b3358000 b335d000 r-xp /usr/lib/libstorage.so.0.1
b336d000 b33cc000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33e2000 b33f6000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3406000 b344a000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b345a000 b3462000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3472000 b34a2000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34b5000 b356e000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3582000 b35d5000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35e6000 b3601000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3611000 b36d2000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36e5000 b36f5000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3705000 b3712000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3723000 b372a000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b373a000 b377b000 r-xp /usr/lib/libmdm.so.1.2.12
b378b000 b3793000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37a2000 b37b2000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37d3000 b3833000 r-xp /usr/lib/libasound.so.2.0.0
b3845000 b3848000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3858000 b385b000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b386b000 b3870000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3880000 b3881000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3891000 b389c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38b0000 b38b7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38c7000 b38cd000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38dd000 b38e2000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38f2000 b390d000 r-xp /usr/lib/libmmfsound.so.0.1.0
b391d000 b3924000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3934000 b3937000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3948000 b3976000 r-xp /usr/lib/libidn.so.11.5.44
b3986000 b399c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39ad000 b39b7000 r-xp /usr/lib/libcares.so.2.1.0
b39c7000 b39d1000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39e1000 b39e3000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39f3000 b39f4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a04000 b3a08000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a19000 b3a41000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a52000 b3a7b000 r-xp /usr/lib/libturbojpeg.so
b3a9b000 b3aa1000 r-xp /usr/lib/libgif.so.4.1.6
b3ab1000 b3af7000 r-xp /usr/lib/libcurl.so.4.3.0
b3b08000 b3b29000 r-xp /usr/lib/libexif.so.12.3.3
b3b44000 b3b59000 r-xp /usr/lib/libtts.so
b3b6a000 b3b72000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b82000 b3c48000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c68000 b3d60000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d7f000 b3e4d000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e64000 b3e66000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e76000 b3e7c000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e8c000 b3eaf000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ec0000 b3ec2000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ed2000 b3ed4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ee5000 b3eea000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f01000 b3f03000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f13000 b3f1a000 r-xp /usr/lib/libsensord-share.so
b3f2a000 b3f42000 r-xp /usr/lib/libsensor.so.1.1.0
b3f53000 b3f56000 r-xp /usr/lib/libXv.so.1.0.0
b3f66000 b3f6b000 r-xp /usr/lib/libutilX.so.1.1.0
b3f7b000 b3f80000 r-xp /usr/lib/libappcore-common.so.1.1
b3f90000 b3f97000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3faa000 b3fae000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fbf000 b409d000 r-xp /usr/lib/libCOREGL.so.4.0
b40bd000 b40c0000 r-xp /usr/lib/libuuid.so.1.3.0
b40d0000 b40e7000 r-xp /usr/lib/libblkid.so.1.1.0
b40f8000 b40fa000 r-xp /usr/lib/libXau.so.6.0.0
b410a000 b4151000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4163000 b4169000 r-xp /usr/lib/libjson-c.so.2.0.1
b417a000 b417e000 r-xp /usr/lib/libogg.so.0.7.1
b418e000 b41b0000 r-xp /usr/lib/libvorbis.so.0.4.3
b41c0000 b42a4000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42c0000 b42c3000 r-xp /usr/lib/libEGL.so.1.4
b42d4000 b42da000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42ea000 b42ec000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42fc000 b4309000 r-xp /usr/lib/libGLESv2.so.2.0
b431a000 b437c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4391000 b43a9000 r-xp /usr/lib/libmount.so.1.1.0
b43bb000 b43cf000 r-xp /usr/lib/libxcb.so.1.1.0
b43df000 b43e6000 r-xp /lib/libcrypt-2.20-2014.11.so
b441e000 b4420000 r-xp /usr/lib/libiri.so
b4430000 b443b000 r-xp /usr/lib/libgpg-error.so.0.15.0
b444c000 b4482000 r-xp /usr/lib/libpulse.so.0.16.2
b4493000 b44d6000 r-xp /usr/lib/libsndfile.so.1.0.25
b44eb000 b4500000 r-xp /lib/libexpat.so.1.5.2
b4512000 b45d0000 r-xp /usr/lib/libcairo.so.2.11200.14
b45e4000 b45ec000 r-xp /usr/lib/libdrm.so.2.4.0
b45fc000 b45ff000 r-xp /usr/lib/libdri2.so.0.0.0
b460f000 b465d000 r-xp /usr/lib/libssl.so.1.0.0
b4672000 b467e000 r-xp /usr/lib/libeeze.so.1.13.0
b468f000 b4698000 r-xp /usr/lib/libethumb.so.1.13.0
b46a8000 b46ab000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46bb000 b4872000 r-xp /usr/lib/libcrypto.so.1.0.0
b565d000 b5666000 r-xp /usr/lib/libXi.so.6.1.0
b5676000 b5678000 r-xp /usr/lib/libXgesture.so.7.0.0
b5688000 b568c000 r-xp /usr/lib/libXtst.so.6.1.0
b569c000 b56a2000 r-xp /usr/lib/libXrender.so.1.3.0
b56b2000 b56b8000 r-xp /usr/lib/libXrandr.so.2.2.0
b56c8000 b56ca000 r-xp /usr/lib/libXinerama.so.1.0.0
b56db000 b56de000 r-xp /usr/lib/libXfixes.so.3.1.0
b56ee000 b56f9000 r-xp /usr/lib/libXext.so.6.4.0
b5709000 b570b000 r-xp /usr/lib/libXdamage.so.1.1.0
b571b000 b571d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b572d000 b580f000 r-xp /usr/lib/libX11.so.6.3.0
b5823000 b582a000 r-xp /usr/lib/libXcursor.so.1.0.2
b583a000 b5852000 r-xp /usr/lib/libudev.so.1.6.0
b5854000 b5857000 r-xp /lib/libattr.so.1.1.0
b5867000 b5887000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5888000 b588d000 r-xp /usr/lib/libffi.so.6.0.2
b589e000 b58b6000 r-xp /lib/libz.so.1.2.8
b58c6000 b58c8000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58d8000 b59ad000 r-xp /usr/lib/libxml2.so.2.9.2
b59c2000 b5a5d000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a79000 b5a7c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a8c000 b5aa5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ab6000 b5ac7000 r-xp /lib/libresolv-2.20-2014.11.so
b5adb000 b5b55000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b6a000 b5b6c000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b7c000 b5b83000 r-xp /usr/lib/libembryo.so.1.13.0
b5b93000 b5b9d000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bae000 b5bc6000 r-xp /usr/lib/libpng12.so.0.50.0
b5bd7000 b5bfa000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c1b000 b5c2f000 r-xp /usr/lib/libector.so.1.13.0
b5c40000 b5c58000 r-xp /usr/lib/liblua-5.1.so
b5c69000 b5cc0000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cd4000 b5cfc000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d0d000 b5d20000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d31000 b5d6b000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d7c000 b5d8a000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d9a000 b5da2000 r-xp /usr/lib/libtbm.so.1.0.0
b5db2000 b5dbf000 r-xp /usr/lib/libeio.so.1.13.0
b5dcf000 b5dd1000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5de1000 b5de6000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5df6000 b5e0d000 r-xp /usr/lib/libefreet.so.1.13.0
b5e1f000 b5e3f000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e4f000 b5e6f000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e71000 b5e77000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e87000 b5e98000 r-xp /usr/lib/libemotion.so.1.13.0
b5ea9000 b5eb0000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ec0000 b5ecf000 r-xp /usr/lib/libeo.so.1.13.0
b5ee0000 b5ef2000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f03000 b5f08000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f18000 b5f31000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f41000 b5f5e000 r-xp /usr/lib/libeet.so.1.13.0
b5f77000 b5fbf000 r-xp /usr/lib/libeina.so.1.13.0
b5fd0000 b5fe0000 r-xp /usr/lib/libefl.so.1.13.0
b5ff1000 b60d6000 r-xp /usr/lib/libicuuc.so.51.1
b60f3000 b6233000 r-xp /usr/lib/libicui18n.so.51.1
b624a000 b6282000 r-xp /usr/lib/libecore_x.so.1.13.0
b6294000 b6297000 r-xp /lib/libcap.so.2.21
b62a7000 b62d0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62e1000 b62e8000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62fa000 b6331000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6342000 b642d000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6440000 b64b9000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64cb000 b64d0000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64e0000 b64ea000 r-xp /usr/lib/libvconf.so.0.2.45
b64fa000 b64fc000 r-xp /usr/lib/libvasum.so.0.3.1
b650c000 b650e000 r-xp /usr/lib/libttrace.so.1.1
b651e000 b6521000 r-xp /usr/lib/libiniparser.so.0
b6531000 b6557000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6567000 b656c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b657d000 b6594000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65a5000 b6610000 r-xp /lib/libm-2.20-2014.11.so
b6621000 b6627000 r-xp /lib/librt-2.20-2014.11.so
b6638000 b6645000 r-xp /usr/lib/libunwind.so.8.0.1
b667b000 b679f000 r-xp /lib/libc-2.20-2014.11.so
b67b4000 b67cd000 r-xp /lib/libgcc_s-4.9.so.1
b67dd000 b68bf000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68d0000 b68fa000 r-xp /usr/lib/libdbus-1.so.3.8.12
b690b000 b6947000 r-xp /usr/lib/libsystemd.so.0.4.0
b6949000 b69cc000 r-xp /usr/lib/libedje.so.1.13.0
b69df000 b69fd000 r-xp /usr/lib/libecore.so.1.13.0
b6a1d000 b6ba4000 r-xp /usr/lib/libevas.so.1.13.0
b6bd9000 b6bed000 r-xp /lib/libpthread-2.20-2014.11.so
b6c01000 b6e35000 r-xp /usr/lib/libelementary.so.1.13.0
b6e64000 b6e68000 r-xp /usr/lib/libsmack.so.1.0.0
b6e78000 b6e7f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e8f000 b6e91000 r-xp /usr/lib/libdlog.so.0.0.0
b6ea1000 b6ea4000 r-xp /usr/lib/libbundle.so.0.1.22
b6eb4000 b6eb6000 r-xp /lib/libdl-2.20-2014.11.so
b6ec7000 b6edf000 r-xp /usr/lib/libaul.so.0.1.0
b6ef3000 b6ef8000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f09000 b6f16000 r-xp /usr/lib/liblptcp.so
b6f28000 b6f2c000 r-xp /usr/lib/libsys-assert.so
b6f3d000 b6f5d000 r-xp /lib/ld-2.20-2014.11.so
b6f6e000 b6f73000 r-xp /usr/bin/launchpad-loader
b8b64000 b8fb9000 rw-p [heap]
be937000 be958000 rw-p [stack]
be937000 be958000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19718)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66a6b84) [/lib/libc.so.6] + 0x2bb84
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
send_result_to_client, pid: -1
06-02 20:23:55.464+0900 E/PKGMGR_SERVER(19844): pkgmgr-server.c: sighandler(417) > child NORMAL exit [19847]
06-02 20:23:57.836+0900 E/PKGMGR_SERVER(19844): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:23:57.836+0900 E/PKGMGR_SERVER(19844): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:23:57.896+0900 W/AUL     (19899): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:23:57.896+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:23:57.906+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:23:57.916+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:23:57.916+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:23:57.916+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 19899
06-02 20:23:57.916+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:23:57.926+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:23:57.926+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:23:57.926+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-4)
06-02 20:23:58.047+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19902, appid: org.example.client
06-02 20:23:58.047+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:23:58.057+0900 W/AUL     (19899): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19902)
06-02 20:23:59.058+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:23:59.058+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-02 20:24:00.549+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:24:00.549+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:24
06-02 20:24:00.549+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:24"
06-02 20:24:00.549+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:24"
06-02 20:24:00.549+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:24:00.549+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145768529 Time: <font_size=31> </font_size> <font_size=31> 오후 8:24</font_size></font>"
06-02 20:24:03.051+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(19902)
06-02 20:24:03.051+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19902, appid: org.example.client, status: bg
06-02 20:24:13.932+0900 I/abc     (19902): abc
06-02 20:24:13.942+0900 I/CAPI_APPFW_APPLICATION(19902): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:24:15.133+0900 I/CAPI_APPFW_APPLICATION(19902): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:24:17.395+0900 E/TBM     (19902): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:24:23.161+0900 D/basicui (19902): successed to load edc file
06-02 20:24:23.201+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:24:23.201+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:24:23.261+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:24:23.261+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:24:23.271+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:24:23.271+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:24:24.272+0900 I/MY_LOG  (19902): change
06-02 20:24:24.332+0900 I/APP_CORE(19902): appcore-efl.c: __do_app(514) > [APP 19902] Event: RESET State: CREATED
06-02 20:24:24.332+0900 I/CAPI_APPFW_APPLICATION(19902): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:24:24.352+0900 I/MY_LOG  (19902): change
06-02 20:24:24.362+0900 W/APP_CORE(19902): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
06-02 20:24:24.362+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:24:24.633+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:24:24.633+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:24:24.643+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:24:24.643+0900 I/APP_CORE(19902): appcore-efl.c: __do_app(514) > [APP 19902] Event: RESUME State: CREATED
06-02 20:24:24.643+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:24:24.643+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:24:24.643+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:24:24.653+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19902) status(3)
06-02 20:24:24.653+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:24:24.653+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:24:24.653+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(19902)
06-02 20:24:24.653+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19902, appid: org.example.client, status: fg
06-02 20:24:24.673+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:24:24.673+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:24:24.673+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:24:24.683+0900 I/APP_CORE(19902): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:24:24.683+0900 I/APP_CORE(19902): appcore-efl.c: __do_app(625) > [APP 19902] Initial Launching, call the resume_cb
06-02 20:24:24.683+0900 I/CAPI_APPFW_APPLICATION(19902): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:24:25.003+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19902) status(0)
06-02 20:24:27.625+0900 I/MY_LOG  (19902): Button pressed
06-02 20:24:27.746+0900 E/VCONF   (19902): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:24:27.746+0900 E/VCONF   (19902): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:24:27.746+0900 E/VCONF   (19902): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:24:27.746+0900 E/VCONF   (19902): vconf.c: vconf_get_bool(2729) > vconf_get_bool(19902) : db/ise/keysound error
06-02 20:24:27.746+0900 E/VCONF   (19902): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:24:27.746+0900 E/VCONF   (19902): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:24:27.806+0900 I/MY_LOG  (19902): Button unpressed
06-02 20:24:27.966+0900 I/MY_LOG  (19902): change
06-02 20:24:29.147+0900 I/MY_LOG  (19902): Button pressed
06-02 20:24:29.247+0900 I/MY_LOG  (19902): Button unpressed
06-02 20:24:29.357+0900 I/MY_LOG  (19902): change
06-02 20:24:29.637+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:24:30.148+0900 I/MY_LOG  (19902): Button pressed
06-02 20:24:30.238+0900 I/MY_LOG  (19902): Button unpressed
06-02 20:24:30.378+0900 I/MY_LOG  (19902): change
06-02 20:24:31.129+0900 I/MY_LOG  (19902): Button pressed
06-02 20:24:31.239+0900 I/MY_LOG  (19902): Button unpressed
06-02 20:24:31.389+0900 I/MY_LOG  (19902): change
06-02 20:24:32.090+0900 I/MY_LOG  (19902): Button pressed
06-02 20:24:32.190+0900 I/MY_LOG  (19902): Button unpressed
06-02 20:24:34.512+0900 I/MY_LOG  (19902): Button pressed
06-02 20:24:34.592+0900 I/MY_LOG  (19902): Button unpressed
06-02 20:24:35.974+0900 I/MY_LOG  (19902): Button pressed
06-02 20:24:36.054+0900 I/MY_LOG  (19902): Button unpressed
06-02 20:24:42.350+0900 D/basicui (19902): successed to load edc file
06-02 20:24:48.826+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:24:48.826+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:24:48.826+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:24:48.826+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:24:48.836+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:24:48.836+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:24:48.836+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-02 20:24:48.836+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:24:48.836+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:24:48.836+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:24:48.836+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:24:48.836+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:24:53.621+0900 W/CRASH_MANAGER(19930): worker.c: worker_job(1199) > 0619902636c691496402693
06-02 20:24:56.794+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:24:56.804+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:24:56.804+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:24:56.804+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:24:56.804+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:24:56.804+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:24:56.844+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:24:56.884+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:24:56.884+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:24:56.884+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:24:56.884+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:24:56.894+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:24:56.914+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:24:56.914+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 20:24:56.914+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:24:56.924+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:24:56.934+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 20:24:56.944+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 20:24:56.944+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:24:56.954+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb8201008]
06-02 20:24:56.954+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 20:24:56.954+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb8201008
06-02 20:24:56.954+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 20:24:56.954+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:24:56.954+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:24:56.954+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 20:24:56.964+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 20:24:56.964+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 20:24:56.964+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 20:24:56.964+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 20:25:00.548+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:25:00.548+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:25
06-02 20:25:00.548+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:25"
06-02 20:25:00.548+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:25"
06-02 20:25:00.558+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:25:00.558+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145706480 Time: <font_size=31> </font_size> <font_size=31> 오후 8:25</font_size></font>"
06-02 20:25:16.103+0900 E/PKGMGR_SERVER(20015): pkgmgr-server.c: main(2414) > package manager server start
06-02 20:25:16.153+0900 E/PKGMGR  (20013): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 20:25:16.193+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 20:25:16.193+0900 E/AUL_AMD (  612): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 19902
06-02 20:25:16.203+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 20:25:16.213+0900 E/PKGMGR_SERVER(20015): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20018]
06-02 20:25:18.635+0900 W/AUL     (20070): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:25:18.635+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:25:18.645+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:25:18.655+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:25:18.655+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:25:18.655+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 20070
06-02 20:25:18.655+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:25:18.665+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:25:18.665+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:25:18.665+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-4)
06-02 20:25:18.785+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20072, appid: org.example.client
06-02 20:25:18.785+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:25:18.785+0900 W/AUL     (20070): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20072)
06-02 20:25:18.835+0900 E/PKGMGR_SERVER(20015): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:25:18.835+0900 E/PKGMGR_SERVER(20015): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:25:19.786+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:25:19.786+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-02 20:25:23.800+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(20072)
06-02 20:25:23.800+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20072, appid: org.example.client, status: bg
06-02 20:25:37.253+0900 E/PKGMGR_SERVER(20128): pkgmgr-server.c: main(2414) > package manager server start
06-02 20:25:37.303+0900 E/PKGMGR  (20126): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 20:25:37.343+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 20:25:37.343+0900 E/AUL_AMD (  612): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 20072
06-02 20:25:37.353+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 20:25:37.363+0900 E/PKGMGR_SERVER(20128): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20131]
06-02 20:25:39.766+0900 W/AUL     (20183): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:25:39.766+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:25:39.776+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:25:39.786+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:25:39.786+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:25:39.786+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 20183
06-02 20:25:39.786+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:25:39.786+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:25:39.796+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:25:39.796+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-4)
06-02 20:25:39.836+0900 E/PKGMGR_SERVER(20128): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:25:39.836+0900 E/PKGMGR_SERVER(20128): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:25:39.906+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20185, appid: org.example.client
06-02 20:25:39.906+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:25:39.926+0900 W/AUL     (20183): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20185)
06-02 20:25:40.917+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:25:40.917+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-02 20:25:44.921+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(20185)
06-02 20:25:44.921+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20185, appid: org.example.client, status: bg
06-02 20:25:45.942+0900 I/abc     (20185): abc
06-02 20:25:45.952+0900 I/CAPI_APPFW_APPLICATION(20185): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:25:47.143+0900 I/CAPI_APPFW_APPLICATION(20185): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:25:49.455+0900 E/TBM     (20185): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:25:50.616+0900 I/APP_CORE(20185): appcore-efl.c: __do_app(514) > [APP 20185] Event: RESET State: CREATED
06-02 20:25:50.616+0900 I/CAPI_APPFW_APPLICATION(20185): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:25:50.646+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:25:50.646+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:25:50.666+0900 W/APP_CORE(20185): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
06-02 20:25:50.666+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:25:50.676+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:25:50.676+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:25:50.686+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:25:50.696+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:25:50.947+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:25:50.947+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:25:50.947+0900 I/APP_CORE(20185): appcore-efl.c: __do_app(514) > [APP 20185] Event: RESUME State: CREATED
06-02 20:25:50.947+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:25:50.947+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:25:50.947+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:25:50.947+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:25:50.957+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(20185) status(3)
06-02 20:25:50.957+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:25:50.957+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:25:50.957+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(20185)
06-02 20:25:50.957+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 20185, appid: org.example.client, status: fg
06-02 20:25:50.967+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:25:50.967+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:25:50.967+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:25:50.977+0900 I/APP_CORE(20185): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:25:50.977+0900 I/APP_CORE(20185): appcore-efl.c: __do_app(625) > [APP 20185] Initial Launching, call the resume_cb
06-02 20:25:50.977+0900 I/CAPI_APPFW_APPLICATION(20185): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:25:51.307+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(20185) status(0)
06-02 20:25:54.991+0900 I/MY_LOG  (20185): Button pressed
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: vconf_get_bool(2729) > vconf_get_bool(20185) : db/ise/keysound error
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:25:55.081+0900 E/VCONF   (20185): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:25:55.141+0900 I/MY_LOG  (20185): Button unpressed
06-02 20:25:55.962+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:25:56.142+0900 I/MY_LOG  (20185): Button pressed
06-02 20:25:56.222+0900 I/MY_LOG  (20185): Button unpressed
06-02 20:25:56.262+0900 D/basicui (20185): successed to load edc file
06-02 20:26:00.556+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:26:00.556+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:26
06-02 20:26:00.556+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:26"
06-02 20:26:00.556+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:26"
06-02 20:26:00.556+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:26:00.556+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145694179 Time: <font_size=31> </font_size> <font_size=31> 오후 8:26</font_size></font>"
06-02 20:26:10.766+0900 W/CRASH_MANAGER(20212): worker.c: worker_job(1199) > 0620185636c691496402770
06-02 20:26:12.448+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:26:12.468+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:26:12.468+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:26:12.468+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:26:12.468+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:26:12.468+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:26:12.488+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:26:12.518+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:26:12.518+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:26:12.518+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:26:12.518+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:26:12.538+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-02 20:26:12.538+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:26:12.548+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:26:12.548+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:26:12.568+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:26:12.588+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-02 20:26:12.598+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-02 20:26:12.598+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:26:12.598+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-02 20:26:12.598+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 20:26:12.598+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:26:12.608+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb81fb0e8]
06-02 20:26:12.608+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
06-02 20:26:12.608+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb81fb0e8
06-02 20:26:12.628+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
06-02 20:26:12.638+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
06-02 20:26:12.638+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-02 20:26:12.638+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-02 20:26:12.638+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:26:33.799+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-02 20:26:48.133+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: main(2414) > package manager server start
06-02 20:26:48.183+0900 E/PKGMGR  (20289): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-02 20:26:48.213+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 14
06-02 20:26:48.213+0900 E/AUL_AMD (  612): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 20185
06-02 20:26:48.223+0900 W/AUL_AMD (  612): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-02 20:26:48.233+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20294]
06-02 20:26:50.495+0900 W/AUL     (20343): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-02 20:26:50.495+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-02 20:26:50.495+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-02 20:26:50.505+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-02 20:26:50.505+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-02 20:26:50.505+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 20343
06-02 20:26:50.505+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-02 20:26:50.515+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-02 20:26:50.515+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 20:26:50.515+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-02 20:26:50.525+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-02 20:26:50.525+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-02 20:26:50.535+0900 I/abc     (19718): abc
06-02 20:26:50.535+0900 I/CAPI_APPFW_APPLICATION(19718): app_main.c: ui_app_main(789) > app_efl_main
06-02 20:26:50.535+0900 I/CAPI_APPFW_APPLICATION(19718): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-02 20:26:50.565+0900 E/TBM     (19718): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-02 20:26:50.625+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 19718, appid: org.example.client
06-02 20:26:50.625+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-02 20:26:50.635+0900 W/AUL     (20343): launch.c: app_request_to_launchpad(425) > request cmd(0) result(19718)
06-02 20:26:50.825+0900 I/APP_CORE(19718): appcore-efl.c: __do_app(514) > [APP 19718] Event: RESET State: CREATED
06-02 20:26:50.825+0900 I/CAPI_APPFW_APPLICATION(19718): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-02 20:26:50.835+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 20:26:50.835+0900 E/PKGMGR_SERVER(20291): pkgmgr-server.c: main(2471) > package manager server terminated.
06-02 20:26:50.835+0900 E/EFL     (19718): edje<19718> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:26:50.835+0900 E/EFL     (19718): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:26:50.855+0900 E/EFL     (19718): edje<19718> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:26:50.855+0900 E/EFL     (19718): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:26:50.855+0900 E/EFL     (19718): edje<19718> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-02 20:26:50.855+0900 E/EFL     (19718): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:26:50.865+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:26:50.865+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:26:50.885+0900 W/APP_CORE(19718): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
06-02 20:26:50.885+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-02 20:26:50.895+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-02 20:26:50.905+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-02 20:26:50.905+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:26:50.915+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:26:51.005+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-02 20:26:51.005+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-02 20:26:51.005+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-02 20:26:51.005+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-02 20:26:51.005+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-02 20:26:51.005+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-02 20:26:51.005+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19718) status(3)
06-02 20:26:51.015+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:26:51.015+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:26:51.015+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(19718)
06-02 20:26:51.015+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 19718, appid: org.example.client, status: fg
06-02 20:26:51.015+0900 I/APP_CORE(19718): appcore-efl.c: __do_app(514) > [APP 19718] Event: RESUME State: CREATED
06-02 20:26:51.025+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-02 20:26:51.025+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-02 20:26:51.025+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-02 20:26:51.025+0900 I/APP_CORE(19718): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-02 20:26:51.025+0900 I/APP_CORE(19718): appcore-efl.c: __do_app(625) > [APP 19718] Initial Launching, call the resume_cb
06-02 20:26:51.025+0900 I/CAPI_APPFW_APPLICATION(19718): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:26:51.366+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(19718) status(0)
06-02 20:26:51.666+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-02 20:26:51.666+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 19718.
06-02 20:26:51.666+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2566
06-02 20:26:52.457+0900 I/UXT     (20358): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-02 20:26:56.020+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-02 20:27:00.565+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-02 20:27:00.565+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 8:27
06-02 20:27:00.565+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 8:27"
06-02 20:27:00.565+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 8:27"
06-02 20:27:00.565+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-02 20:27:00.565+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145665954 Time: <font_size=31> </font_size> <font_size=31> 오후 8:27</font_size></font>"
06-02 20:27:12.566+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951429736
06-02 20:27:12.576+0900 I/MY_LOG  (19718): Button pressed
06-02 20:27:12.646+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951429813
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: vconf_get_bool(2729) > vconf_get_bool(19718) : db/ise/keysound error
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-02 20:27:12.656+0900 E/VCONF   (19718): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-02 20:27:12.707+0900 I/MY_LOG  (19718): Button unpressed
06-02 20:27:13.477+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951430647
06-02 20:27:13.487+0900 I/MY_LOG  (19718): Button pressed
06-02 20:27:13.557+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951430724
06-02 20:27:13.567+0900 I/MY_LOG  (19718): Button unpressed
06-02 20:27:13.597+0900 D/basicui (19718): successed to load edc file
06-02 20:27:13.627+0900 E/EFL     (19718): elementary<19718> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x8007bbdf into part 'swallow_content'
06-02 20:27:15.009+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951432175
06-02 20:27:15.109+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951432274
06-02 20:27:15.169+0900 E/EFL     (19718): edje<19718> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p9';
06-02 20:27:15.169+0900 E/EFL     (19718): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 20:27:15.900+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=951433058
06-02 20:27:15.950+0900 E/EFL     (19718): ecore_x<19718> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=951433113
06-02 20:27:15.950+0900 E/EFL     (19718): eo<19718> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_widget_item.eo.c:56: unable to resolve regular api func 'elm_wdg_item_part_text_get' 0xb6d9e9e9 in class 'Elm_Hoversel'.
06-02 20:27:16.090+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 19718 pgid = 19718
06-02 20:27:16.090+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(19718)
06-02 20:27:16.090+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:27:16.130+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-02 20:27:16.130+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-02 20:27:16.130+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-02 20:27:16.140+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[19718] terminate event is forwarded
06-02 20:27:16.140+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-02 20:27:16.140+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 19718, ]
06-02 20:27:16.140+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-02 20:27:16.140+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-02 20:27:16.140+0900 I/Tizen::App( 1233): (512) > Not registered pid(19718)
06-02 20:27:16.140+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-02 20:27:16.140+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-02 20:27:16.140+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 19718
06-02 20:27:16.140+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 19718
06-02 20:27:16.140+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 19718
06-02 20:27:16.150+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2570
06-02 20:27:16.160+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-02 20:27:16.160+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 20:27:16.160+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-02 20:27:16.160+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-02 20:27:16.160+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-02 20:27:16.170+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-02 20:27:16.180+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-02 20:27:16.180+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 19718.
06-02 20:27:16.190+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-02 20:27:16.190+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-02 20:27:16.190+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-02 20:27:16.200+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-02 20:27:16.210+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-02 20:27:16.230+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-02 20:27:16.240+0900 W/CRASH_MANAGER(20365): worker.c: worker_job(1199) > 0619718636c69149640283
